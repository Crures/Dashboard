import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { User } from '../Models/User';

@Injectable()
export class ConfigService {
  constructor(private http: HttpClient) { }

  getUsers() {
    return this.http.get<User[]>('/api/User');
  }
}
