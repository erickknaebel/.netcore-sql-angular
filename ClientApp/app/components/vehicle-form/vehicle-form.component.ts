import { Component, OnInit } from '@angular/core';
import { MakeService } from "../../services/make.service";
import { FeatureService } from "../../services/feature.service";

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
        private _makeService: MakeService, 
        private _featureService: FeatureService) { }

    ngOnInit() {
        this._makeService.getMakes().subscribe(makes => 
            this.makes = makes);

        this._featureService.getFeatures().subscribe(features => 
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
