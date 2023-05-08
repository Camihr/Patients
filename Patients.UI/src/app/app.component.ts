import { Component, OnInit } from '@angular/core';
import { MastersService } from './services/masters.service';
import { PersonsService } from './services/persons.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})

export class AppComponent implements OnInit{
  constructor( private personsService : PersonsService) { }

  ngOnInit(){
    this.personsService.patientsEnables()
    .subscribe(data => {
      if(data != null){
        this.arePatientsEnables = data.data
      }
    })
  }

  arePatientsEnables : boolean = false
}
