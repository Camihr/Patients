import { Component, Input, Output, EventEmitter, OnInit } from '@angular/core';

@Component({
  selector: 'app-popup',
  templateUrl: './popup.component.html',
  styleUrls: ['./popup.component.scss'],
})
export class PopupComponent implements OnInit {
  ngOnInit(): void {
    this.maxWidthStyle =
      this.maxWidth > 0 ? `max-width: ${this.maxWidth}px` : 'max-width: 900px';
  }

  @Input() title: string = '';
  @Input() maxWidth: number = 900;
  @Output() close = new EventEmitter();
  maxWidthStyle: string = '';

  closePopup() {
    this.close.emit();
  }
}
