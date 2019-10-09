import * as tslib_1 from "tslib";
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
var ServicesService = /** @class */ (function () {
    function ServicesService(_http) {
        this._http = _http;
        this._ListOfServicesURL = "/api/GetAllServices";
        this._ReciveContentURL = "/api/ReciveContent";
        this._options = {
            headers: new HttpHeaders().set('Content-Type', 'application/json')
                .set('Accept', 'application/json')
        };
    }
    ServicesService.prototype.GetAllServices = function () {
        return this._http.get(this._ListOfServicesURL);
    };
    ServicesService.prototype.sendValuesToServer = function (model) {
        return this._http.post(this._ReciveContentURL, JSON.stringify(model), this._options);
    };
    ServicesService = tslib_1.__decorate([
        Injectable({
            providedIn: 'root'
        }),
        tslib_1.__metadata("design:paramtypes", [HttpClient])
    ], ServicesService);
    return ServicesService;
}());
export { ServicesService };
//# sourceMappingURL=services.service.js.map