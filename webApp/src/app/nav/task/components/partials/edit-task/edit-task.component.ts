import { OnInit } from "@angular/core";
import { Component } from "@angular/core";

@Component({
    selector: 'app-edit-task',
    templateUrl: './edit-task.component.html'
})
export class EditTaskComponent implements OnInit{
    constructor(

    ){}
    panelOpenState: boolean = false;
    items:{id:number}[] = [{id: 1}];

    ngOnInit(): void {

    }

}