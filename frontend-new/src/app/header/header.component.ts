import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
})
export class HeaderComponent implements OnInit {
  @Output() toggleSidebarForMe: EventEmitter<any> = new EventEmitter();

  constructor(private router: Router) { }

  ngOnInit(): void { }

  toggleSidebar() {
    this.toggleSidebarForMe.emit();
  }

  login() {
    this.router.navigate(['./login'])
    console.log("Hitting on login");
  }

  signUp() {
    this.router.navigate(['./signup'])
    console.log("Hitting on signup");
  }
}
