import { Component, ChangeDetectionStrategy } from '@angular/core';
import {
  CalendarDayViewBeforeRenderEvent, CalendarEvent, CalendarMonthViewBeforeRenderEvent,
  CalendarView, CalendarWeekViewBeforeRenderEvent,
} from 'angular-calendar';
import * as moment from 'moment';
import { ViewPeriod } from 'Calendar-Utils';
import { ChangeDetectorRef } from '@angular/core';
import { Subject } from 'rxjs';
import { CalendarService } from 'src/app/_Globals/service/calendar.service';
import { CalendarModel } from 'src/app/_Globals/Models/CalendarModel';
import { AuthenticationService } from 'src/app/_Globals/service/authentication.service';



@Component({
  selector: 'app-dashboard-widgets-datetime',
  // changeDetection: ChangeDetectionStrategy.OnPush,
  templateUrl: './datetime.component.html',
  styles: ['./datetime.component.scss']
})

export class DatetimeComponent {
  calendarEvents: CalendarEvent[];
  calEvent: CalendarModel;

  constructor(
    private cdr: ChangeDetectorRef, private calendarService: CalendarService, private authService: AuthenticationService, 
  ) {
    this.calendarService.getEventsForUser(authService.currentUserValue.id).toPromise().then(b => {
      b.forEach(element => {
        element.start = new Date(element.start);
        element.end = new Date(element.end);
      }); 
      this.calendarEvents = b;
    });
  }

  eventClicked( event : CalendarEvent ){
    
    this.calendarService.getCalendarEvent(+event.id).toPromise().then(
      b => this.calEvent = b
    );
  }
  
  view: CalendarView = CalendarView.Week;

  viewDate = moment().toDate();
  refresh: Subject<any> = new Subject();


funk(){}

  viewPeriod: ViewPeriod;

  updateCalendarEvents(
    viewRender:
      | CalendarMonthViewBeforeRenderEvent
      | CalendarWeekViewBeforeRenderEvent
      | CalendarDayViewBeforeRenderEvent
  ): void {
    // console.log(this.calendarEvents);
    if (
      
      !this.viewPeriod ||
      !moment(this.viewPeriod.start).isSame(viewRender.period.start) ||
      !moment(this.viewPeriod.end).isSame(viewRender.period.end)
    ) {
      this.viewPeriod = viewRender.period;

      this.cdr.detectChanges();
    }
  }
}
