import { Component, OnInit} from '@angular/core';

@Component({
  selector: 'app-second',
  templateUrl: './second.component.html',
  styleUrls: ['./second.component.css']
})
export class SecondComponent implements OnInit {

  message: string | undefined;

  constructor() {}

  ngOnInit() {
    this.message = 'Hello, debugging!';
    console.log(this.message); 
  }

}
