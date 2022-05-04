import { Component, OnInit } from '@angular/core';
import { Tickets } from '../models/Tickets';
import { TicketsService } from '../tickets.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-tickethome',
  templateUrl: './tickethome.component.html',
  styleUrls: ['./tickethome.component.scss']
})
export class TickethomeComponent implements OnInit {

  tickets$ = this._ticketsService.getTickets();

   tickets: Tickets[] = [];

  constructor(private _ticketsService: TicketsService) { }
  
  
  ngOnInit(): void {
    this._ticketsService.getTickets().subscribe(tickets => {
      this.tickets = tickets;
    })
  }

}


