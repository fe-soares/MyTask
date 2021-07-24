import { Component } from "@angular/core";
import { MatDialog } from '@angular/material/dialog';
import { EditTaskComponent } from "../partials/edit-task/edit-task.component";

@Component({
    selector: 'task-do',
    templateUrl: './taskDo.component.html'
})
export class TaskDoComponent{
    constructor(public dialog: MatDialog) {}

    editTaskDialog() {
      const dialogRef = this.dialog.open(EditTaskComponent, { disableClose: true });
  
      dialogRef.afterClosed().subscribe(result => {
        console.log(`Dialog result: ${result}`);
      });
    }
}