import { ServicesService } from "./Services/services.service";
import { Component, ViewChild, ElementRef } from '@angular/core';
import { EmailDto } from './Classes/email-dto';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AngularProj';
  ServicesList: [];
  @ViewChild('closeServiceModal') closeservceModal: ElementRef;
  @ViewChild('openIntrestedModal') openintrestedModal: ElementRef;
  serviceType;
  intrested;
  username;
  email;
  phone;
  constructor(private _getServices: ServicesService)
  {
    this._getServices.GetAllServices().subscribe(r=>{
      this.ServicesList=r["result"];
    })
  }

  srvcSubmit(event){
    // console.log(this.serviceType);
    this.openintrestedModal.nativeElement.click();
 
  }


  submit(event){
    let model =new EmailDto();
    model.username=this.username;
    model.email=this.email;
    model.mobile=this.phone;
    model.schedule=this.intrested;
    model.serviceType=this.serviceType;
    this._getServices.sendValuesToServer(model).subscribe(r=>{
      console.log(r);
    });
  }
}
