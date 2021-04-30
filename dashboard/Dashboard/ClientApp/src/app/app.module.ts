import { BetereCounterComponent } from './betere-counter/betere-counter.page';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { CounterComponent } from './counter/counter.component';
import { DatetimeComponent } from './dashboard/widgets/datetime/datetime.component';
import { ClickerComponent } from './dashboard/widgets/clicker/clicker.component';
import { LoginComponent } from './login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    DashboardComponent,
    CounterComponent,
    BetereCounterComponent,
    DatetimeComponent,
    ClickerComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: DashboardComponent, pathMatch: 'full' },
      { path: 'login', component: LoginComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
