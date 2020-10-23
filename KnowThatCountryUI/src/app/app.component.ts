import { Component } from '@angular/core';
import { CountryService } from './country.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'KnowThatCountryUI';
  countryService:CountryService;
  countries=[];
  /**
   *
   */
  constructor(private tCountryService:CountryService) {
      this.countryService=tCountryService;
      this.GetAll();
  }

  GetAll(){
    this.countryService.GetAll().subscribe(response=>this.countries=response);
  }
}
