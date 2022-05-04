import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
<<<<<<< HEAD
import { Ticket } from './models/Ticket';
=======
import { Tickets } from './models/Tickets';
>>>>>>> 33beac8c2b3a94ebe86dc85c075ed1326eb85322
import { PutTicket, User } from './models/User';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(private httpClient: HttpClient) { }
  baseUrl = "https://localhost:5001/Users";

  putTicket(user: PutTicket) {
    return this.httpClient.put<User>(this.baseUrl, user);
  }

  getUsers() {
    return this.httpClient.get<Array<User>>(this.baseUrl);
  }

  deleteUser(id: number) {
    return this.httpClient.delete<User> (`${this.baseUrl}`) //need to update the rest of the url for the ticket id
  }

  postUser(user: PutTicket) {
    return this.httpClient.post<User>(this.baseUrl, user);

  }

  getUser(id: number) {
    return this.httpClient.get<User>(`${this.baseUrl}/${id}`);
  }
}
