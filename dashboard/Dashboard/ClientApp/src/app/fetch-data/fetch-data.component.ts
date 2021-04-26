import { User } from './../_Globals/Models/User';
import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent implements OnInit {
  asd: User;

  constructor(private http: HttpClient) {
    // http.get<User[]>('api/User/getUsers').subscribe(result => {
    //   console.log(1);
    // }, error => console.error(error));
  }

  Test() {
    console.log(1);
    return this.http.get('api/User/getUsers');
  }

  ngOnInit() {
    
    this.Test();
  }

}
