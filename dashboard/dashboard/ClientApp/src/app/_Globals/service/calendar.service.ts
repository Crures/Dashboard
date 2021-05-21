import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { CalendarModel } from "../Models/CalendarModel";

@Injectable({ providedIn: 'root' })
export class CalendarService {
    constructor(private http: HttpClient) { }

    getEventsForUser(userId) {
        return this.http.get<CalendarModel[]>(`api/Calendar/GetUserEvents/${userId}`);
    }
    getCalendarEvent(calEventId: number) {
        return this.http.get<CalendarModel>(`api/Calendar/${calEventId}` );
    }
}

