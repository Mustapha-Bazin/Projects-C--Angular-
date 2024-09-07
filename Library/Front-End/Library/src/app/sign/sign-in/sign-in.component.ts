import { Component } from '@angular/core';
import { Register } from '../../interface/register';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrl: './sign-in.component.css'
})
export class SignInComponent {
  title:string="Create Account";
  paragraph:string="Enter your name, email and password to create account: ";
  user:Register={id:0,name:"",mail:"",password:""};
  error:string=""
  password:string=""
  url:string="https://localhost:7169/api/User/Add/User"
  constructor(private httpClient:HttpClient){}
  createAccount():void{
    const dataRegister:Register={
      id:0,
      name:this.user.name,
      mail:this.user.mail,
      password:this.user.password
    }
    if(this.password!=dataRegister.password){
      this.error="**error password**"
    }else{
      this.httpClient.post(this.url,dataRegister).subscribe({
        next:Response=>console.log(Response),
        error:e=>console.log("erro "+e),
        complete:()=>console.log("completed")
      })
      console.log("welcom");
    }
  
  }
}
