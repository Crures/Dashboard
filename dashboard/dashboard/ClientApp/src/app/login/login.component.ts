import { Component } from '@angular/core';
import { User } from '../_Globals/Models/User';
import { ConfigService } from '../_Globals/service/config.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
})
export class LoginComponent {
  user: User[]=[];
  constructor(private ConfigService: ConfigService){
    // ConfigService.getUsers().subscribe(users => {this.user = users; console.log(this.user)});
  }
  
  asd(){
    this.ConfigService.getUsers().subscribe(users => {this.user = users; console.log(this.user)});
    
  }
}

