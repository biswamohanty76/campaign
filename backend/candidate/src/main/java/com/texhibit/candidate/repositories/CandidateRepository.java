package com.texhibit.candidate.repositories;

import com.texhibit.candidate.entities.Candidate;
import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface CandidateRepository extends MongoRepository<Candidate,String> {

}
