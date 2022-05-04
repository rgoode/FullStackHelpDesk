import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Ticket } from './models/Ticket';
import { PutTicket } from './models/User';


@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(private httpClient: HttpClient) { }
  baseUrl = "https://localhost:5001/Users";



  putTicket(user: PutTicket) {
    return this.httpClient.put<Ticket>(this.baseUrl, user);
  }

  
}
