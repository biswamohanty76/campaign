package com.texhibit.job.services;

import com.texhibit.job.converters.ConvertToJobDto;
import com.texhibit.job.dtos.JobDto;
import com.texhibit.job.entities.Job;
import com.texhibit.job.repositories.JobRepository;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class JobService {

    private final JobRepository jobRepository;

    public JobService(JobRepository jobRepository) {
        this.jobRepository = jobRepository;
    }

    public List<JobDto> getAll(){
        List<Job> jobList = jobRepository.findAll();
        List<JobDto> transformedJobList = ConvertToJobDto.convert(jobList);
        return transformedJobList;
    }

    public Job createJob(Job request) {
        return  jobRepository.save(request);

    }

    public Job updateJob(String id, Job job) {
        job.setId(id);
        return jobRepository.save(job);
    }

    public Optional<Job> getJob(String id) {
        Optional<Job> job = jobRepository.findById(id);
        return  job;
    }

    public String deleteJob(String id) {
        jobRepository.deleteById(id);
        return "Job with id "+ id +" deleted successfully..";
    }

    public Integer getCount() {
        return Math.toIntExact(jobRepository.count());
    }

    public boolean publishJob(String id) {
        Optional<Job> job = jobRepository.findById(id);
        Job jobToPublish = job.get();
        jobToPublish.setPublished(true);
        jobRepository.save(jobToPublish);
        return true;
    }
}
