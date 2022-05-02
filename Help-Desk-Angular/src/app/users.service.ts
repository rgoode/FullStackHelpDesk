import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Tickets } from './models/Tickets';
import { PutTicket } from './models/User';


@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(private httpClient: HttpClient) { }
  baseUrl = "https://localhost:5001/Tickets";



  putTicket(user: PutTicket) {
    return this.httpClient.put<Tickets>(this.baseUrl, user);
  }
}
