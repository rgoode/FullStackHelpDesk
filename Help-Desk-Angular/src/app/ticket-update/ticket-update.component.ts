import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { PutTicket } from '../models/Users';
import { TicketsService } from '../tickets.service';
import { UsersService } from '../users.service';

@Component({
  selector: 'app-ticket-update',
  templateUrl: './ticket-update.component.html',
  styleUrls: ['./ticket-update.component.scss']
})
export class TicketUpdateComponent implements OnInit {

  // ---ASK JAMES---

  constructor(private _usersService: UsersService) { }  
  updateTicketFormGroup = new FormGroup({
    priority: new FormControl(''),
    assignedTo: new FormControl(''),
    solution: new FormControl(''),
    status: new FormControl(''),
    resolvedTime: new FormControl('')
  })

  updateTicket() {
    const putTicket: PutTicket = this.updateTicketFormGroup.value;
    this._usersService.putTicket(putTicket).subscribe();
  }


  // constructor(private _ticketsService: TicketsService) { }  
  // updateTicketFormGroup = new FormGroup({
  //   priority: new FormControl(''),
  //   assignedTo: new FormControl(''),
  //   solution: new FormControl(''),
  //   status: new FormControl(''),
  //   resolvedTime: new FormControl('')
  // })

  // updateTicket() {
  //   const putTicket: PutTicket = this.updateTicketFormGroup.value;
  //   this._ticketClientService.putTicket(putTicket).subscribe();
  // }

  ngOnInit(): void {
    
  }


}
