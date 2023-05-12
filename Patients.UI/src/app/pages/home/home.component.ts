import { Component, OnInit } from '@angular/core';
import { PersonsService } from 'src/app/services/persons.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  constructor(private personsService: PersonsService, private router: Router) {}

  ngOnInit() {
    this.personsService.patientsEnables().subscribe(
      (data) => {
        if (data != null) {
          this.arePatientsEnables = data.data;
        }
      },
      (errorMessage) => {
        console.error(errorMessage);
      }
    );
  }

  arePatientsEnables: boolean = false;

  navigateToPersons() {
    this.router.navigate(['/persons']);
  }
}
