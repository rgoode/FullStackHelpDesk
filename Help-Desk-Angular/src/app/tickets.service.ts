import { Injectable } from '@angular/core';
import { PostTicket, Tickets } from './models/Tickets';

@Injectable({
  providedIn: 'root'
})
export class TicketsService {

  constructor() { }

  postTicket(ticket: PostTicket) {
    return this.httpClient.post<Tickets>(this.baseUrl, ticket);
  }

}
