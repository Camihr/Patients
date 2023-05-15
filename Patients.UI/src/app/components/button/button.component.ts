import { Component, Input, Output, EventEmitter, OnInit } from '@angular/core';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.scss'],
})
export class ButtonComponent implements OnInit {
  ngOnInit(): void {
    this.setButtonStyle();
  }

  @Input() isFull: boolean = false;
  @Input() isSubmit: boolean = false;
  @Input() btnStyle: string = '';
  @Output() click = new EventEmitter();
  btnClass: string = '';
  buttonType: string = '';

  setButtonStyle() {
    this.buttonType = this.isSubmit ? 'submit' : 'button';

    this.btnClass = 'btn btn-';
    if (
      this.btnStyle === 'primary' ||
      this.btnStyle === 'secondary' ||
      this.btnStyle === 'danger'
    ) {
      this.btnClass += this.btnStyle;
    } else {
      this.btnClass += 'default';
    }

    if (this.isFull) {
      this.btnClass += ' btn-full';
    }
  }

  doClick() {
    this.click.emit();
  }
}
