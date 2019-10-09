import * as tslib_1 from "tslib";
import { ServicesService } from "./Services/services.service";
import { Component, ViewChild, ElementRef } from '@angular/core';
import { EmailDto } from './Classes/email-dto';
var AppComponent = /** @class */ (function () {
    function AppComponent(_getServices) {
        var _this = this;
        this._getServices = _getServices;
        this.title = 'AngularProj';
        this._getServices.GetAllServices().subscribe(function (r) {
            _this.ServicesList = r["result"];
        });
    }
    AppComponent.prototype.srvcSubmit = function (event) {
        // console.log(this.serviceType);
        this.openintrestedModal.nativeElement.click();
        var model = new EmailDto();
        model.username = this.username;
        model.email = this.email;
        model.mobile = this.phone;
        model.schedule = this.intrested;
        model.serviceType = this.serviceType;
        this._getServices.sendValuesToServer(model).subscribe(function (r) {
            console.log(r);
        });
    };
    tslib_1.__decorate([
        ViewChild('closeServiceModal'),
        tslib_1.__metadata("design:type", ElementRef)
    ], AppComponent.prototype, "closeservceModal", void 0);
    tslib_1.__decorate([
        ViewChild('openIntrestedModal'),
        tslib_1.__metadata("design:type", ElementRef)
    ], AppComponent.prototype, "openintrestedModal", void 0);
    AppComponent = tslib_1.__decorate([
        Component({
            selector: 'app-root',
            templateUrl: './app.component.html',
            styleUrls: ['./app.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [ServicesService])
    ], AppComponent);
    return AppComponent;
}());
export { AppComponent };
//# sourceMappingURL=app.component.js.map