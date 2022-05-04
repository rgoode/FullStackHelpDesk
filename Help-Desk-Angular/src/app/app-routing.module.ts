import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllTicketsComponent } from './all-tickets/all-tickets.component';
import { FavoriteComponent } from './favorite/favorite.component';
import { NewRequestFormComponent } from './new-request-form/new-request-form.component';
import { TicketUpdateComponent } from './ticket-update/ticket-update.component';
import { TickethomeComponent } from './tickethome/tickethome.component';
import { UserLoginComponent } from './user-login/user-login.component';

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
    component: NewRequestFormComponent
  },
  {
    path: "ticket-update",
    component: TicketUpdateComponent
  },
  {
    path: "favorite",
    component: FavoriteComponent
  },
  {
    path: "user-login",
    component: UserLoginComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
