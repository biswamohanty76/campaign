package com.texhibit.candidate.dtos;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.stereotype.Component;

@Builder
@AllArgsConstructor
@NoArgsConstructor
@Data
public class CandidateDto {
    private String name;
    private String id;
    private String email;
    private String phone;
    private String gender;
    private String dob;
}
