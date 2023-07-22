package com.texhibit.candidate.entities;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.data.annotation.Id;
import org.springframework.data.mongodb.core.mapping.Document;
import org.springframework.stereotype.Indexed;

import java.util.List;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Document(collection = "candidate")
@Indexed
public class Candidate{
    @Id
    private String id;
    private PersonalInformation personalInformation;
    private List<WorkExperience> workExperience;
    private List<Education> education;
    private List<String> skills;
    private List<CertificationsAndLicense> certificationsAndLicenses;
    private List<Reference> references;
    private String resumeOrCV;
    private String resumePath;
    private double currentCtc;
    private double expectedCtc;
    private String currentCompany;
    private Integer noticePeriod;
    private String techStack;
    private String flag;
    private String activeStatus;
    private String preferences;
    private Integer activeApps;
    private Integer totalApps;
}


