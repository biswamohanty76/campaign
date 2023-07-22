package com.texhibit.candidate.entities;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class Education {
    private String schoolName;
    private String degreeType;
    private String major;
    private String graduationDate;
    private String gPA;
}