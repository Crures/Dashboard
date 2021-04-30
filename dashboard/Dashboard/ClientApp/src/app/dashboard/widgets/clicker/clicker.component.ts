import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard-widgets-clicker',
  templateUrl: './clicker.component.html',
})
export class ClickerComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
