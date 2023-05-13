import { Component, OnInit } from '@angular/core';
import { PersonsService } from 'src/app/services/persons.service';
import { Router } from '@angular/router';
import { UNKNOWN_ERROR } from '../../consts/consts';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  constructor(private personsService: PersonsService, private router: Router) { }

  ngOnInit() {
    this.personsService.patientsEnables().subscribe(
      data => {
        this.arePatientsEnables = data.data;
      },
      error => {
        console.error(error);
        if (error.error.message != undefined) {
          console.error(error.error.message);
          console.error(error.error.exception);
        }
        else{
          console.error(UNKNOWN_ERROR);
        }
      }
    );
  }

  arePatientsEnables: boolean = false;

  navigateToPersons() {
    this.router.navigate(['/persons']);
  }
}
