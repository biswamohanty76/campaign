package com.texhibit.candidate.entities;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class WorkExperience {
    private String companyName;
    private String jobTitle;
    private String employmentDates;
    private String jobDescription;
    private String accomplishments;
    private double experienceFrom;
    private double experienceTo;
}
