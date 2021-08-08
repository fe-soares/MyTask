import { Component } from "@angular/core";
import { MatDialog } from "@angular/material/dialog";
import { StepTaskComponent } from "../formStep/step-task.component";

@Component({
    selector: 'app-new-task',
    templateUrl: './new-task.component.html'
})
export class NewTaskComponent{
    constructor(
        public dialog: MatDialog
    ){}

    panelOpenState: boolean = false;
    items:{id:number}[] = [{id: 1}];

    addNewStepTask(){
        const dialogRef = this.dialog.open(StepTaskComponent, { disableClose: true });
  
        dialogRef.afterClosed().subscribe(result => {
            this.items.push(result);
        });
    }

    createNewTask(){
        let newTask: any = {};
        return newTask;
    }
}