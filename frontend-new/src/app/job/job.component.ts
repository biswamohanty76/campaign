import { Component, OnInit } from '@angular/core';
import { Job } from './job.model';
import { JobService } from './job.service';

@Component({
  selector: 'app-job',
  templateUrl: './job.component.html',
  styleUrls: ['./job.component.scss']
})
export class JobComponent implements OnInit {

  jobs: Job[]
  displayedColumns = [ 'title', 'location', 'company', 'experience','salary','action']
  constructor(private jobService:JobService) { }

  ngOnInit(): void {
    this.jobService.read().subscribe(jobs => {
      this.jobs = jobs
      console.log(jobs);
    })
  }

}
