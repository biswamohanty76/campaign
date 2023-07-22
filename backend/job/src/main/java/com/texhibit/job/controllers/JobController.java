package com.texhibit.job.controllers;

import com.texhibit.job.dtos.JobDto;
import com.texhibit.job.entities.Job;
import com.texhibit.job.services.JobService;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;

@RestController
@RequestMapping(value= "/api")
@CrossOrigin
public class JobController {

    private final JobService jobService;

    public JobController(JobService jobService) {
        this.jobService = jobService;
    }

    @GetMapping(value = "/jobs")
    public List<JobDto> getJobs(){
        return jobService.getAll();
    }

    @PostMapping(value = "/jobs")
    public Job createJob(@RequestBody Job request){
        return jobService.createJob(request);
    }

    @PutMapping("/jobs/{id}")
    public Job updateJob(@PathVariable String id, @RequestBody Job job){
        return jobService.updateJob(id, job);
    }

    @GetMapping("/jobs/{id}")
    public Optional<Job> getjob(@PathVariable String id){
        return jobService.getJob(id);
    }

    @DeleteMapping("/jobs/{id}")
    public String deleteJob(@PathVariable String id){

        return jobService.deleteJob(id);
    }

    @GetMapping("/jobs/count")
    public Integer getCount(){
        return jobService.getCount();
    }

    @GetMapping("/jobs/publish/{id}")
    public boolean publishJob(@PathVariable String id){
        return jobService.publishJob(id);
    }
}
