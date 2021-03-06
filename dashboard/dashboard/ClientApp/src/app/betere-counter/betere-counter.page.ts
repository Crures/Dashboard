import { Component } from '@angular/core';

@Component({
  selector: 'app-betere-counter-page',
  templateUrl: './betere-counter.page.html',
  styleUrls: ['./betere-counter.page.scss']
})
export class BetereCounterComponent {
  public currentCount = 0;
  public date = new Date();

  public incrementCounter() {
    this.currentCount += 2;
  }
}
