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
      route: "new-request-form",
      text: "New Request"
    },
    {
      route: "ticket-update",
      text: "Update A Ticket"
    },
    {
      route: "all-tickets",
      text: "All The Tickets"
    },
    {
      route: "favorite",
      text: "Favorites/Assigned"
    }

  ]

  ngOnInit(): void {
  }

}
