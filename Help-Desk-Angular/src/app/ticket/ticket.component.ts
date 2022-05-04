import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { filter, map, switchMap } from 'rxjs';
import { TicketsService } from '../tickets.service';

@Component({
  selector: 'app-ticket',
  templateUrl: './ticket.component.html',
  styleUrls: ['./ticket.component.scss']
})
export class TicketComponent implements OnInit {

  constructor(
    private _activatedRoute: ActivatedRoute, 
    private _ticketClientService: TicketsService
  ) { }

  singleTicket$ = this._activatedRoute.paramMap.pipe(
    map(params => params.get('id')), 
    filter(id => id !== null), 
    map(id => parseInt(id as string, 10)), 
    switchMap((id: number) => this._ticketClientService.getTicket(id)),
  )  

  ngOnInit(): void {
  }

}
