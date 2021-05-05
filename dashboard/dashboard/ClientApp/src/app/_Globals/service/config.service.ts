import { User } from './../Models/User';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ConfigService {
  constructor(private http: HttpClient) { }

  getUsers() {
    return this.http.get<User[]>('/api/User');
  }

  getUser(user: User) {
    return this.http.get<User>('/api/User/' + user.email);
  }
}
