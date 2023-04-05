import { Component, OnInit } from '@angular/core';
import { Candidate } from './candidate.model';
import { CandidateService } from './candidate.service';

@Component({
  selector: 'app-candidate',
  templateUrl: './candidate.component.html',
  styleUrls: ['./candidate.component.css']
})
export class CandidateComponent implements OnInit {

  candidates: Candidate[]
  displayedColumns = ['id', 'name', 'email', 'phone', 'gender']
  constructor(private candidateService:CandidateService) { }

  ngOnInit(): void {
    this.candidateService.read().subscribe(candidates => {
      this.candidates = candidates
      console.log(candidates);
    })
  }

}
