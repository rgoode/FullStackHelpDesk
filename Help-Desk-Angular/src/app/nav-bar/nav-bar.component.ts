import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.scss']
})
export class NavBarComponent implements OnInit {

  constructor() { }
  public routes = [
    {
      route: "",
      text: "Home"
    },
    {
      route: "",
      text: "New Request"
    },
    {
      route: "",
      text: "Update A Ticket"
    },
    {
      route: "",
      text: "Completed Tickets"
    },
    {
      route: "",
      text: "All Tickets"
    },

  ]

  ngOnInit(): void {
  }

}
