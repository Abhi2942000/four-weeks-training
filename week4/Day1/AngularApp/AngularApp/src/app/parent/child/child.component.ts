import { Component, Input, Output, EventEmitter } from '@angular/core';


@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css'],
//   template: `
//   {{ item }}
//   <button (click)="remove.emit(item)">Remove</button>
// `,

// template: `
// <div (click)="handleClick()">{{ item }}</div>
// `,
})
export class ChildComponent {

  // @Input()
  // item!: string;
  // @Output() remove = new EventEmitter<string>();

  @Input()
  item: string | undefined;
  @Output() itemClicked = new EventEmitter<string>();

  handleClick() {
    this.itemClicked.emit(this.item);
  }
}
