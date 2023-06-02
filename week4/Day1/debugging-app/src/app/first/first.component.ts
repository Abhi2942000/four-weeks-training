import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-first',
  templateUrl: './first.component.html',
  styleUrls: ['./first.component.css']
})
export class FirstComponent implements OnInit {
  message: string | undefined;

  constructor() {}

  ngOnInit() {
    this.message = 'Hello, debugging!';
    console.log(this.message); 
  }
  
  }


