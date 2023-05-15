import { Component, OnInit } from '@angular/core';
import { PersonsService } from 'src/app/services/persons.service';
import { Router } from '@angular/router';
import { setError } from '../../utils/errorManage';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  constructor(private personsService: PersonsService, private router: Router) {}

  ngOnInit() {
    this.patientsEnables();
  }

  arePatientsEnables: boolean = false;

  patientsEnables() {
    this.personsService.patientsEnables().subscribe(
      (data) => {
        this.arePatientsEnables = data.data;
      },
      (error) => {
        setError(error);
      }
    );
  }

  navigateToPersons() {
    this.router.navigate(['/persons']);
  }
}
