import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SvgComponent } from './components/svg/svg.component';
import { HomeComponent } from './pages/home/home.component';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { PatientsComponent } from './pages/patients/patients.component';
import { PersonsComponent } from './pages/persons/persons.component';
import { ManagementPersonComponent } from './components/management-person/management-person.component';

@NgModule({
  declarations: [
    AppComponent,
    SvgComponent,
    HomeComponent,
    NotFoundComponent,
    PatientsComponent,
    PersonsComponent,
    ManagementPersonComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
