import { Component, OnInit } from '@angular/core';
import { switchMap } from 'rxjs';
import { Tickets } from '../models/Tickets';
import { TicketsService } from '../tickets.service';

@Component({
  selector: 'app-favorite',
  templateUrl: './favorite.component.html',
  styleUrls: ['./favorite.component.scss']
})
export class FavoriteComponent implements OnInit {
  
  tickets$ = this.ticketClientService.favoriteTickets(0); 
  
   tickets: Tickets[] = [];

  constructor(private ticketClientService: TicketsService) { }

  favoriteTickets(id: number){
    this.ticketClientService.favoriteTickets(id).pipe(
      switchMap(() => this.ticketClientService.getTickets())
    ).subscribe((tickets: Tickets[]) =>{
      this.tickets = tickets
    });
  }

  ngOnInit(): void {
  }

}
