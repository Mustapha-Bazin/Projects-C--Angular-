import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SignUpComponent } from '../sign/sign-up/sign-up.component';
import { SignInComponent } from '../sign/sign-in/sign-in.component';
const routes: Routes = [
  {path:"LogIn",component:SignUpComponent},
  {path:"SignIn",component:SignInComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
