package com.texhibit.candidate.services;

import com.texhibit.candidate.converters.ConvertToCandidateDto;
import com.texhibit.candidate.dtos.CandidateDto;
import com.texhibit.candidate.entities.Candidate;
import com.texhibit.candidate.repositories.CandidateRepository;
import com.texhibit.candidate.utils.Parser;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.io.IOException;
import java.util.List;
import java.util.Optional;

@Service
public class CandidateService {
    @Autowired
    private CandidateRepository candidateRepository;

    public List<CandidateDto> getAll() {
        List<Candidate> candidates = candidateRepository.findAll();
        List<CandidateDto> candidateDtos = ConvertToCandidateDto.convert(candidates);
        return candidateDtos;
    }

    public Candidate addCandidate(Candidate candidate) throws IOException {
        String parseResume =  Parser.parse(candidate.getResumePath());
        candidate.setResumeOrCV(parseResume);
        Candidate temp = candidateRepository.save(candidate);

        return temp;
    }

    public Candidate updateCandidate(String id, Candidate candidate) {
        candidate.setId(id);
        return candidateRepository.save(candidate);
    }

    public String deleteCandidate(String id) {
        candidateRepository.deleteById(id);
        return "Candidate with id "+ id +" deleted successfully..";
    }

    public Optional<Candidate> getCandidate(String id) {
        Optional<Candidate> candidate = candidateRepository.findById(id);
        return  candidate;
    }

    public Integer getCount() {
        return Math.toIntExact(candidateRepository.count());
    }
}
