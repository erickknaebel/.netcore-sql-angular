import { Component, OnInit } from '@angular/core';
import { MakeService } from "../../services/make.service";

@Component({
    selector: 'vehicle-form',
    templateUrl: './vehicle-form.component.html'
})
export class VehicleFormComponent {

    private makes: any[];

    private models: any [];

    private vehicle: any = {};

    constructor(private _makeService: MakeService) { }

    ngOnInit() {
        this._makeService.getMakes().subscribe(makes => 
            this.makes = makes);
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
