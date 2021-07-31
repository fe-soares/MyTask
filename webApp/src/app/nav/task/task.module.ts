import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { UserPanelComponent } from "../userPanel/uerPanel.component";
import { TaskDashboardComponent } from "./task-dashboard/task-dashboard.component";
import { TaskAppComponent } from "./task.app.component";
import { TaskRoutingModule } from "./task.route";
import { MatTabsModule } from '@angular/material/tabs';
import { MatButtonModule } from '@angular/material/button';
import { TaskDoComponent } from "./components/task-do/taskDo.component";
import { TaskDoneComponent } from "./components/task-done/taskDone.component";
import { TaskToDoComponent } from "./components/task-to-do/taskToDo.component";
import { EditTaskComponent } from "./components/partials/edit-task/edit-task.component";
import { MatDialogModule  } from "@angular/material/dialog";
import { MatExpansionModule } from '@angular/material/expansion';
import { NewTaskComponent } from "./components/partials/new-task/new-task.component";
import { StepTaskComponent } from "./components/partials/formStep/step-task.component";

@NgModule({
    declarations: [
        TaskAppComponent,
        TaskDashboardComponent,
        TaskDoComponent,
        TaskDoneComponent,
        TaskToDoComponent,
        EditTaskComponent,
        NewTaskComponent,
        StepTaskComponent
    ],
    imports: [
        CommonModule,
        TaskRoutingModule,
        MatTabsModule,
        MatButtonModule,
        MatDialogModule,
        MatExpansionModule
    ],
    providers: [
      //  ProdutoService,
    ]
    ,
    exports: [
        TaskDashboardComponent
    ]
})export class TaskModule{
}