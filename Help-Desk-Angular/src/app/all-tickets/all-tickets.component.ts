import { Component, OnInit } from '@angular/core';
import { Tickets } from '../models/Tickets';
import { TicketsService } from '../tickets.service';

@Component({
  selector: 'app-all-tickets',
  templateUrl: './all-tickets.component.html',
  styleUrls: ['./all-tickets.component.scss']
})
export class AllTicketsComponent implements OnInit {

  tickets$ = this.ticketClientService.getTickets();

   tickets: Tickets[] = [];

  constructor(private ticketClientService: TicketsService) { }

  ngOnInit(): void {
    this.ticketClientService.getTickets().subscribe(tickets => {
      this.tickets = tickets;
    })
  }

}

// METHOD FOR FAVORITE BUTTON / CLICK EVENT