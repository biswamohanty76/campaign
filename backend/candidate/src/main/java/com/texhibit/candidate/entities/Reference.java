package com.texhibit.candidate.entities;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class Reference {
    private String name;
    private String jobTitle;
    private String companyName;
    private String email;
    private String phoneNumber;
}
