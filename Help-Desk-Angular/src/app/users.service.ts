import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
<<<<<<< HEAD
import { Ticket } from './models/Ticket';
import { PutTicket, User } from './models/User';

=======
import { Tickets } from './models/Tickets';
import { PutTicket, Users } from './models/Users';
>>>>>>> 667b3bc50d12cf3dd5d98630d80c275708777a74





@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(private httpClient: HttpClient) { }
  baseUrl = "https://localhost:5001/Users";

  putTicket(user: PutTicket) {
    return this.httpClient.put<Users>(this.baseUrl, user);
  }

  getUsers() {
    return this.httpClient.get<Array<Users>>(this.baseUrl);
  }

  deleteUser(id: number) {
    return this.httpClient.delete<Users> (`${this.baseUrl}`) //need to update the rest of the url for the ticket id
  }

  postUser(user: PutTicket) {
    return this.httpClient.post<Users>(this.baseUrl, user);

  }

  getUser(id: number) {
    return this.httpClient.get<Users>(`${this.baseUrl}/${id}`);
  }
}
