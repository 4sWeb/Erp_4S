import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { MainMenue_VM } from '../../../models/MainMenue/Mainmenue_vm';
import { Response_VM } from '../../../models/Shared/ReSponse_VM';
import { UsersService } from '../../../services/User/users.service';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {
  Response_VM: Response_VM = new Response_VM();
  application_VM: MainMenue_VM = new MainMenue_VM();
  constructor(private userService: UsersService, private router: Router) { }

  ngOnInit() {
    this.userService.GetAllModule().subscribe
      (
        result => {
          console.log("result", result);
          this.Response_VM = result;
          this.application_VM = this.Response_VM.data;
          console.log("application_VM", this.application_VM);
        }
      );

  }
  GetAPPId(AppId: number) {
    localStorage.setItem('AppId', AppId.toString());
    this.router.navigate([`/transaction-list/`]);

  }
}
