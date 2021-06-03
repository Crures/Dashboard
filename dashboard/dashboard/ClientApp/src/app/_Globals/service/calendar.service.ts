import { HttpClient } from "@angular/common/http";
import { Identifiers } from "@angular/compiler";
import { calcPossibleSecurityContexts } from "@angular/compiler/src/template_parser/binding_parser";
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

    createEvent(calM: CalendarModel){
        
        this.http.post<CalendarModel>(`api/Calendar/`, calM).subscribe();
    }
}

