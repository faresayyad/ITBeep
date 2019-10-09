import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { EmailDto } from '../Classes/email-dto';
@Injectable({
  providedIn: 'root'
})
export class ServicesService {
  private _ListOfServicesURL = "/api/GetAllServices";
  private _ReciveContentURL = "/api/ReciveContent";
  private _options = {
    headers: new HttpHeaders().set('Content-Type', 'application/json')
      .set('Accept', 'application/json')
  };

  constructor(private _http: HttpClient) { }
  GetAllServices() {
    return this._http.get(this._ListOfServicesURL);
  }

  sendValuesToServer(model:EmailDto){
    return this._http.post(this._ReciveContentURL, JSON.stringify(model), this._options);
  }
}
