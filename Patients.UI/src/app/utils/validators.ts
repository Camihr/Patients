import { AbstractControl } from '@angular/forms';

export class MyValidators {
  static validatePrice(control: AbstractControl) {
    const value = control.value;
    if (value > 1000) {
      return { invalid_price: true };
    }
    return null;
  }

  static validatePassword(control: AbstractControl) {
    const value = control.value;
    if (!containsNumber(value)) {
      return { invalid_password: true };
    }
    return null;
  }

  static maxLength(text: string, count: number): string {
    if (text.length > count) {
      return `El texto no puede tener más de ${count} caracteres`;
    }
    return '';
  }
}

function containsNumber(value: string): boolean {
  return value.split('').find((v) => isNumber(v)) != undefined;
}

function isNumber(value: string): boolean {
  return !isNaN(parseInt(value, 10));
}
