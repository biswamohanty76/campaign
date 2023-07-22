package com.texhibit.candidate.entities;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class ContactInformation {
    private String email;
    private String phoneNumber;
    private String address;
    private String nationality;
    private String workAuthorizationStatus;
    private String gender;
    private String dateOfBirth;
}