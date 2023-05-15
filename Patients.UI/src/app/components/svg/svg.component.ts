import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-svg',
  templateUrl: './svg.component.html',
  styleUrls: ['./svg.component.scss'],
})
export class SvgComponent {
  @Input() name: string = '';

  @Output() click = new EventEmitter();

  doClick() {
    this.click.emit();
  }
}
