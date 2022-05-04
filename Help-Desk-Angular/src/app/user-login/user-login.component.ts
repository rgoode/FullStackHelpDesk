import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { Users } from '../models/Users';
import { UsersService } from '../users.service';
import { FavoriteComponent } from '../favorite/favorite.component';

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: ['./user-login.component.scss']
})
export class UserLoginComponent implements OnInit {

  constructor(router: Router, _usersService: UsersService) { }

  userLoginFormGroup = new FormGroup({
    userName: new FormControl(''),
    password: new FormControl(''),
  })

  users: Users[] = []


 
  ngOnInit(): void {
  }

}
