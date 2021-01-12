
import {Injectable} from '@angular/core'
import {HttpClientModule, HttpClient} from '@angular/common/http'
import { Country } from './CountriesModel';

@Injectable({
    providedIn:'root'
})
export class CountryService{

    apiURL="http://localhost:5005/Countries/GetAll"
    httpClient:HttpClient

    constructor(private thttpClient: HttpClient) {
        this.httpClient=thttpClient;

    }
    GetAll(){
        return this.httpClient.get<Country[]>(this.apiURL)
        
    }
}