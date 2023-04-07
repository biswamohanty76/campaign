import { Component, OnInit } from '@angular/core';
import { HeaderService } from 'src/app/components/template/header/header.service';

@Component({
  selector: 'app-candidate-view',
  templateUrl: './candidate-view.component.html',
  styleUrls: ['./candidate-view.component.css']
})
export class CandidateViewComponent implements OnInit {

  constructor(private headerService: HeaderService) {
    this.headerService.headerData = {
      title: "Candidates",
      icon: "people",
      routeUrl: "/candidates",
    };

  }

  ngOnInit(): void {}

  // navigateToCandidates(): void {
  //   this.router.navigate(["/candidates"]);
  // }

}
