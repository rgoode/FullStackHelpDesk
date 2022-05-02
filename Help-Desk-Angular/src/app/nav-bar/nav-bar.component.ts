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
      route: "tickethome",
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
      route: "all-tickets",
      text: "All The Tickets"
    },

  ]

  ngOnInit(): void {
  }

}
