import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  template: `
  <h1>Communication between Parent and Child Components</h1>
  <app-parent></app-parent>
`,
})
export class AppComponent {
  title = 'AngularWeek4';
}
