import { Component, OnInit } from '@angular/core';
import { Tickets } from '../models/Tickets';
import { TicketsService } from '../tickets.service';
import { switchMap } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { FavoriteComponent } from '../favorite/favorite.component';
import { TicketUpdateComponent } from '../ticket-update/ticket-update.component';
import { Users } from '../models/Users';
import { UsersService } from '../users.service';


@Component({
  selector: 'app-all-tickets',
  templateUrl: './all-tickets.component.html',
  styleUrls: ['./all-tickets.component.scss']
})

export class AllTicketsComponent implements OnInit {

  tickets$ = this._ticketsService.getTickets();

   tickets: Tickets[] = [];

  constructor(private _ticketsService: TicketsService) { }

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
    });

  }

}



// METHOD FOR FAVORITE BUTTON / CLICK EVENT