import { Component } from "@angular/core";

@Component({
    selector: 'app-form-step',
    templateUrl: './step-task.component.html'
})
export class StepTaskComponent{
    constructor(

    ){}

    saveStep(){
        return {id: 1};
    }

    panelOpenState: boolean = false;
}