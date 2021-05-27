import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { User } from "../Models/User";

@Injectable({ providedIn: 'root' })
export class UserService {
    constructor(private http: HttpClient) { }

    getAll() {
        return this.http.get<User[]>(`api/User`);
    }

    register(user: User) {
        return this.http.post(`api/User/register`, user);
    }

    delete(id: number) {
        return this.http.delete(`api/User/users/${id}`);
    }
}