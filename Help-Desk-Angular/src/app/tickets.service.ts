import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { PostTicket, Ticket } from './models/Ticket';

@Injectable({
  providedIn: 'root'
})
export class TicketsService {

  constructor(private httpClient: HttpClient) { }
  baseUrl = "https://localhost:5001/Tickets";

  getTickets() {
    return this.httpClient.get<Array<Ticket>>(this.baseUrl);
  }

  deleteTicket(id: number) {
    return this.httpClient.delete<Ticket>(`${this.baseUrl}/${id}`); //need to update the rest of the url for the ticket id
  }

  postTicket(ticket: PostTicket) {
    return this.httpClient.post<Ticket>(this.baseUrl, ticket);
  }

  favoriteTickets(id: number){
    return this.httpClient.put<Ticket>(this.baseUrl, id);
  }

  favoriteTicket(id: number) {
    throw new Error('Method not implemented.');
  }

  
}
