import { Component, OnInit } from '@angular/core';
import { PersonsService } from 'src/app/services/persons.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  constructor(private personsService: PersonsService) {}

  ngOnInit() {
    this.personsService.patientsEnables().subscribe((data) => {
      if (data != null) {
        this.arePatientsEnables = data.data;
      }
    });
  }

  arePatientsEnables: boolean = false;
}
