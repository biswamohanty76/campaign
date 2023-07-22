package com.texhibit.job.entities;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.data.annotation.Id;
import org.springframework.data.mongodb.core.mapping.Document;

import java.util.List;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Document(collection = "job")
public class Job {
    @Id
    private String id;
    private String title;
    private String description;
    private String employmentType;
    private String industry;
    private HiringOrganization hiringOrganization;
    private JobLocation jobLocation;
    private BaseSalary baseSalary;
    private String validThrough;
    private List<String> skills;
    private Integer positions;
    private ExperienceRange experienceRange;
    private boolean isPublished;
}
