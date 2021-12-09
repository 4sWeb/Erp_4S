import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Response_VM } from '../../../models/Shared/ReSponse_VM';
import { UserCredential_VM } from '../../../models/Users/UserCredential_VM';
import { Users_VM } from '../../../models/Users/Users_VM';
import { UsersService } from '../../../services/User/users.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  invalidLogin: boolean = false;
  buttonSubmit: boolean = false;
  errorMsg: string;
  eMsg: string;
  User: UserCredential_VM = new UserCredential_VM();
  userResponse: Users_VM = new Users_VM();
  Response: Response_VM = new Response_VM();
  loginForm = new FormGroup({
    userName: new FormControl(null, [Validators.required]),
    password: new FormControl(null, [
      Validators.required,
      Validators.minLength(3),
    ]),
  });

  constructor(private userService: UsersService, private router: Router) { }

  ngOnInit() {
  }
  get userName() {
    return this.loginForm.get('userName');
  }
  get password() {
    return this.loginForm.get('password');
  }
  onSubmit(body: any) {
    this.User = { Username: body.userName, Userpassword: body.password }

    console.log("body", body);
    console.log("User", this.User);
    this.buttonSubmit = true;
    this.userService.CheckUserCredential(this.User).subscribe(
      (result: any) => {
        console.log("result", result)
        this.Response = result;
        console.log("result", this.Response);
        this.userResponse = this.Response.data;
        console.log("this.userResponse", this.userResponse);
        if (this.Response.statusCode == 200)
        {
          this.router.navigate([`/main/`]);
        }
        else
        {
          this.invalidLogin = true;
          this.errorMsg = this.Response.message;
          this.buttonSubmit = false;
        }
        console.log("Result", result)
        //localStorage.setItem('access_token', result.token);
        //this.userService.getToken()?.toString();
        //this.Carteservice.uploadProductsToServer();
      }
    );
  }
}
