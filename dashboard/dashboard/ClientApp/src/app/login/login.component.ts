import { Component } from '@angular/core';
import { User } from '../_Globals/Models/User';
import { ConfigService } from '../_Globals/service/config.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
})
export class LoginComponent {
  users: User[]=[];
  user: User;
  login: User = new User();
  constructor(private ConfigService: ConfigService){
    // ConfigService.getUsers().subscribe(users => {this.user = users; console.log(this.user)});
  }
  
  asd(){
    this.ConfigService.getUsers().subscribe(users => {this.users = users; console.log(this.users)});
    
  }

  dsa() {
    console.log(this.login);
    
    this.ConfigService.getUser(this.login).subscribe(user => {this.user = user; console.log(this.user)});
  }
}

