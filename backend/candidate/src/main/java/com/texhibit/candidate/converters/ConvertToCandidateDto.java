package com.texhibit.candidate.converters;

import com.texhibit.candidate.dtos.CandidateDto;
import com.texhibit.candidate.entities.Candidate;

import java.util.ArrayList;
import java.util.List;

public class ConvertToCandidateDto {
    public static List<CandidateDto> convert(List<Candidate> candidatesList){
        List<CandidateDto> candidateDtos = new ArrayList<>();
        if(!(candidatesList.size() == 0)){
            for (Candidate candidate:candidatesList) {
                CandidateDto candidateDto = CandidateDto
                        .builder()
                        .id(candidate.getId())
                        .dob(candidate.getPersonalInformation().getContactInformation().getDateOfBirth())
                        .email(candidate.getPersonalInformation().getContactInformation().getEmail())
                        .name(candidate.getPersonalInformation().getName())
                        .gender(candidate.getPersonalInformation().getContactInformation().getGender())
                        .phone(candidate.getPersonalInformation().getContactInformation().getPhoneNumber())
                        .build();
                candidateDtos.add(candidateDto);
            }
        }
        return candidateDtos;
    }
}
