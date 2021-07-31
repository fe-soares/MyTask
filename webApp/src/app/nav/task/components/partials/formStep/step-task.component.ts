import { Component } from "@angular/core";

@Component({
    selector: 'app-form-step',
    templateUrl: './step-task.component.html'
})
export class StepTaskComponent{
    constructor(

    ){}
    panelOpenState: boolean = false;
    items:{id:number}[] = [{id: 1}];
}