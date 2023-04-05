package com.texhibit.candidate.entities;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.data.annotation.Id;
import org.springframework.data.mongodb.core.mapping.Document;

@Data
@AllArgsConstructor
@NoArgsConstructor
//@Document(collection = "candidate")
public class CandidateOld {

    @Id
    private String id;
    private String name;
    private String email;
    private String mobile;
    private String dob;
}
