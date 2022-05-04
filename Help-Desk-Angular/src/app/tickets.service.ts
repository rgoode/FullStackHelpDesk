import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { PostTicket, Tickets } from './models/Tickets';
import { PutTicket } from './models/User';

@Injectable({
  providedIn: 'root'
})
export class TicketsService {

  constructor(private httpClient: HttpClient) { }
  baseUrl = "https://localhost:5001/Tickets";

  getTickets() {
    return this.httpClient.get<Array<Tickets>>(this.baseUrl);
  }

  deleteTicket(id: number) {
    return this.httpClient.delete<Tickets>(`${this.baseUrl}/${id}`); //need to update the rest of the url for the ticket id
  }

  postTicket(ticket: PostTicket) {
    return this.httpClient.post<Tickets>(this.baseUrl, ticket);
  }

  favoriteTickets(id: number){
    return this.httpClient.put<Tickets>(this.baseUrl, id);
  }

<<<<<<< HEAD

  favoriteTicket(id: number) {
    throw new Error('Method not implemented.');
  }

=======
>>>>>>> 33beac8c2b3a94ebe86dc85c075ed1326eb85322
  getTicket(ticketID: number) {
    return this.httpClient.get<Ticket>(`${this.baseUrl}/${ticketID}`);
  }

  putTicket(user: PutTicket) {
    return this.httpClient.put<Tickets>(this.baseUrl, user);
  }

}
