import { Component, ViewEncapsulation } from "@angular/core";
import { MatDialog } from "@angular/material/dialog";
import { NewTaskComponent } from "../components/partials/new-task/new-task.component";

@Component({
    selector: 'task-dashboard',
    templateUrl: './task-dashboard.component.html',
    styleUrls: ['./task-dashboard.component.css'],
    encapsulation: ViewEncapsulation.None
})
export class TaskDashboardComponent{
    constructor(public dialog: MatDialog){
    }

    includeNewTask(){
        const dialogRef = this.dialog.open(NewTaskComponent, { disableClose: true });
  
        dialogRef.afterClosed().subscribe(result => {
          console.log(`Dialog result: ${result}`);
        });
    }
}