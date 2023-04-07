import { Component, OnInit } from '@angular/core';
import { Candidate } from './candidate.model';
import { CandidateService } from './candidate.service';

@Component({
  selector: 'app-candidate',
  templateUrl: './candidate.component.html',
  styleUrls: ['./candidate.component.scss']
})
export class CandidateComponent implements OnInit {

  candidates: Candidate[]
  displayedColumns = [ 'name', 'email', 'phone', 'gender','action']
  constructor(private candidateService:CandidateService) { }

  ngOnInit(): void {
    this.candidateService.read().subscribe(candidates => {
      this.candidates = candidates
      console.log(candidates);
    })
  }

}
