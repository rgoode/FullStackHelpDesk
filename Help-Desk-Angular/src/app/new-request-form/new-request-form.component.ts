import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { TicketsService } from '../tickets.service';
import { PostTicket } from '../models/Tickets';

@Component({
  selector: 'app-new-request-form',
  templateUrl: './new-request-form.component.html',
  styleUrls: ['./new-request-form.component.scss']
})
export class NewRequestFormComponent {

  constructor(private _ticketsService: TicketsService) { }

  newRequestFormGroup = new FormGroup({
    submitterName: new FormControl(''),
    submitterEmail: new FormControl(''),
    subjectLine: new FormControl(''),
    problem: new FormControl(''),

  })
  submitTicket() {
    const postTicket: PostTicket = this.newRequestFormGroup.value;
    this._ticketsService.postTicket(postTicket).subscribe();
  }

  reloadCurrentPage() {
    window.location.reload();
   }



}
