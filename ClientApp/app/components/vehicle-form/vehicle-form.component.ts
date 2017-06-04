import { Component, OnInit } from '@angular/core';
import { VehicleService } from "../../services/vehicle.service";
@Component({
    selector: 'vehicle-form',
    templateUrl: './vehicle-form.component.html'
})
export class VehicleFormComponent {

    private makes: any[];

    private models: any [];

    private vehicle: any = {};

    private features: any = [];

    constructor(
        private _vehicleService: VehicleService) { }

    ngOnInit() {
        this._vehicleService.getMakes().subscribe(makes => 
            this.makes = makes);

        this._vehicleService.getFeatures().subscribe(features => 
            this.features = features);
    }

    onMakeChange() {

       var selectedMake = this.makes.find(m => m.id == this.vehicle.make);
       /*
        For large datasets we should create a service to return the makes.
        this.models = someServiceMethod() ? selectedMake.models : []; 
       */
       this.models = selectedMake ? selectedMake.models : []; 
    }
}
