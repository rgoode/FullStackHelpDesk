import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllTicketsComponent } from './all-tickets/all-tickets.component';
import { CompletedTicketsComponent } from './completed-tickets/completed-tickets.component';
import { NewRequestFormComponent } from './new-request-form/new-request-form.component';
import { TicketUpdateComponent } from './ticket-update/ticket-update.component';
import { TickethomeComponent } from './tickethome/tickethome.component';

const routes: Routes = [
  {
    path: "",
    component: TickethomeComponent
  },
  {
    path:"all-tickets",
    component: AllTicketsComponent
  },
  {
    path:"new-request-form",
    component:NewRequestFormComponent
  },
  {
    path:"completed",
    component: CompletedTicketsComponent
  },
  {
    path: "update-ticket",
    component: TicketUpdateComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
