package com.texhibit.job.converters;

import com.texhibit.job.dtos.JobDto;
import com.texhibit.job.entities.Job;

import java.util.ArrayList;
import java.util.List;

public class ConvertToJobDto {
    public static List<JobDto> convert(List<Job> jobs) {
        List<JobDto> jobList = new ArrayList<>();
        if (!(jobs.size() == 0)) {
            for (Job job : jobs) {
                JobDto jobDto = JobDto
                        .builder()
                        .id(job.getId())
                        .title(job.getTitle())
                        .Company(job.getHiringOrganization().getName())
                        .ExpRange(job.getExperienceRange().getExpFrom().toString() + "-"+job.getExperienceRange().getExpTo().toString())
                        .Location(job.getJobLocation().getAddress().getAddressLocality())
                        .Salary(job.getBaseSalary().getValue().toString() + job.getBaseSalary().getCurrency())
                        .build();
                jobList.add(jobDto);
            }
        }
        return jobList;
    }
}
