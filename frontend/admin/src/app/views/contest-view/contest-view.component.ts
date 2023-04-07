import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HeaderService } from 'src/app/components/template/header/header.service';

@Component({
  selector: 'app-contest-view',
  templateUrl: './contest-view.component.html',
  styleUrls: ['./contest-view.component.css']
})
export class ContestViewComponent implements OnInit {

  constructor(private router: Router, private headerService: HeaderService) {
    this.headerService.headerData = {
      title: "Contests",
      icon: "campaign",
      routeUrl: "/contests",
    };
  }

  ngOnInit() {
  }

}
