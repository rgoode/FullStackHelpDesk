import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { AllTicketsComponent } from './all-tickets/all-tickets.component';
import { FavoriteComponent } from './favorite/favorite.component';
import { TicketUpdateComponent } from './ticket-update/ticket-update.component';
import { NewRequestFormComponent } from './new-request-form/new-request-form.component';
import { TickethomeComponent } from './tickethome/tickethome.component';
import { ReactiveFormsModule } from '@angular/forms';
import { UserLoginComponent } from './user-login/user-login.component';
import { TicketComponent } from './ticket/ticket.component';




@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    AllTicketsComponent,
    FavoriteComponent,
    TicketUpdateComponent,
    NewRequestFormComponent,
    TickethomeComponent,
    UserLoginComponent,

    


    TicketComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

