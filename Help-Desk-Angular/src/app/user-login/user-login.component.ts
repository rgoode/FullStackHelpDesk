import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { UsersService } from '../users.service';

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

 
  ngOnInit(): void {
  }

}
