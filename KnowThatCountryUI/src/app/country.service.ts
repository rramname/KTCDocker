
import {Injectable} from '@angular/core'
import {HttpClientModule, HttpClient} from '@angular/common/http'
import { Country } from './CountriesModel';
/**
 * https://www.itsolutionstuff.com/post/how-to-create-service-in-angular-8-using-cliexample.html
 * 
 */
@Injectable({
    providedIn:'root'
})
export class CountryService{

    apiURL="http://apiservice/Countries/GetAll"
    httpClient:HttpClient

    constructor(private thttpClient: HttpClient) {
        this.httpClient=thttpClient;

    }
    GetAll(){
        return this.httpClient.get<Country[]>(this.apiURL)
        
    }
}