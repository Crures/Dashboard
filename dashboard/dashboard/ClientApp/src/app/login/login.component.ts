import { AuthenticationService } from './../_Globals/service/authentication.service';
import { Component } from '@angular/core';
import { User } from '../_Globals/Models/User';
import { ActivatedRoute, Router } from '@angular/router';
import { first } from 'rxjs/operators';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
})
export class LoginComponent {
  loginCred: User = new User();
  returnUrl: string;

  constructor(private route: ActivatedRoute, private router: Router, private auth: AuthenticationService) {
    if (this.auth.currentUserValue) {
      this.router.navigate(['/']);
    }
  }

  login() {
    this.auth.login(this.loginCred.email, this.loginCred.password)
    .pipe(first())
    .subscribe(
        data => {
            this.router.navigate(['/']);
            // this.router.navigate([this.returnUrl]);
        },
        error => {
            console.log(error);
            
        });
  }
}
