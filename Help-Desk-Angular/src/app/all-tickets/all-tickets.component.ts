import { Component, OnInit } from '@angular/core';
import { Tickets } from '../models/Tickets';
import { switchMap } from 'rxjs';
import { TicketsService } from '../tickets.service';
import { RouterModule, Routes } from '@angular/router';
import { TicketUpdateComponent } from '../ticket-update/ticket-update.component';
import { PutTicket, Users } from '../models/Users';

@Component({
  selector: 'app-all-tickets',
  templateUrl: './all-tickets.component.html',
  styleUrls: ['./all-tickets.component.scss']
})

export class AllTicketsComponent implements OnInit {

  tickets$ = this._ticketsService.getTickets();


  tickets: Tickets[] = [];

  
  constructor(
    private _ticketsService: TicketsService) { }

  ngOnInit(): void {
    this._ticketsService.getTickets().subscribe(tickets => {
      this.tickets = tickets;
    })
    
  }

  deleteTicket(id: number) {
    this._ticketsService.deleteTicket(id).pipe(
    switchMap(() => this._ticketsService.getTickets())
    ).subscribe(tickets => {
      this.tickets = tickets
    })
  }


}




function id(id: any) {
  throw new Error('Function not implemented.');
}
// METHOD FOR FAVORITE BUTTON / CLICK EVENT