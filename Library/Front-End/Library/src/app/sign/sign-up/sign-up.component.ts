import { Component } from '@angular/core';
import { User } from '../../interface/user';
@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrl: './sign-up.component.css'
})
export class SignUpComponent {
title:string="Login";
paragraph:string="Enter your username and password to login: ";
user:User={userName:"",password:""};

login():void{
  const dataLogin:User={
    userName:this.user.userName,
    password:this.user.password
  }
console.log("hello "+dataLogin.userName);
}
}
