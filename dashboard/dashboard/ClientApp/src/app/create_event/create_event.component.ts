import { Component, OnInit } from '@angular/core';
import { User } from '../_Globals/Models/User';
import { UserService } from '../_Globals/service/user.service';

@Component({
  selector: 'app-create_event-component',
  templateUrl: './create_event.component.html'
})

export class CreateEventComponent implements OnInit{
  startDate: Date;
  endDate: Date;
  startDateTime: string;
  endDateTime: string;
  users: User[];
  selectedPeople: User[];

  constructor(
    private userService: UserService,
  ) {}

  showSelected(){console.log(this.selectedPeople);
  }

  ngOnInit(){
    this.FetchData().then( ()=>{
      console.log(this.users)}
    )
  }
  FetchData(){
    return this.userService.getAll().toPromise().then(b => {
      this.users = b;
    });
  }
}