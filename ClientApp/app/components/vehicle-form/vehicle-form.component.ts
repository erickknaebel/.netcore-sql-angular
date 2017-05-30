import { Component, OnInit } from '@angular/core';
import { MakeService } from "../../services/make.service";

@Component({
    selector: 'vehicle-form',
    templateUrl: './vehicle-form.component.html'
})
export class VehicleFormComponent {

    private makes;

    constructor(private _makeService: MakeService) { }

    ngOnInit() {
        this._makeService.getMakes().subscribe(makes => 
            this.makes = makes);
    }
}
