import { Component, OnInit } from '@angular/core';
import { MakeService } from "../../services/make.service";

@Component({
    selector: 'vehicles',
    templateUrl: './vehicle.component.html'
})
export class VehicleFormComponent implements OnInit {

    makes: any[];
    models: any[];
    vehicle: any = {};

    /**
     *
     */
    constructor( private _makeService: MakeService) {}
        
    ngOnInit() {
        this._makeService.getMake()
        .subscribe( makes => this.makes = makes);
    }

    onMakeChange() {
        var selectedMake = this.makes.find(m => m.id == this.vehicle.make);
        this.models = selectedMake ? selectedMake.models : [];
        
    }

}
