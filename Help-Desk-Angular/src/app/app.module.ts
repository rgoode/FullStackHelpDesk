import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { AllTicketsComponent } from './all-tickets/all-tickets.component';
import { CompletedTicketsComponent } from './completed-tickets/completed-tickets.component';
import { FavoriteComponent } from './favorite/favorite.component';
import { TicketUpdateComponent } from './ticket-update/ticket-update.component';
import { NewRequestFormComponent } from './new-request-form/new-request-form.component';

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    AllTicketsComponent,
    CompletedTicketsComponent,
    FavoriteComponent,
    TicketUpdateComponent,
    NewRequestFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
