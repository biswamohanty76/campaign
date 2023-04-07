package com.texhibit.job.dtos;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.stereotype.Component;

@AllArgsConstructor
@NoArgsConstructor
@Data
@Builder
public class JobDto {
    private String id;
    private String title;
    private String Company;
    private String ExpRange;
    private String Location;
    private String Salary;
}
