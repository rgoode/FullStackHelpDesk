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
    private _ticetClientService: TicketsService
  ) { }

  ticket$ = this._activatedRoute.paramMap.pipe( 
    map(params => params.get('ticketID')),  
    filter(ticketID => ticketID !== null), 
    map(ticketID => parseInt(ticketID as string, 10)), 
    switchMap((ticketID: number) => this._ticetClientService.getTicket(ticketID)), 
  )

  ngOnInit(): void {
  }

}
