import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { TaskDashboardComponent } from "./task-dashboard/task-dashboard.component";
import { TaskAppComponent } from "./task.app.component";

const taskRouterConfig: Routes = [
    {path: '', component: TaskAppComponent,
        children:[
            {path: '', redirectTo: 'tasks', pathMatch: 'full'},
            {path: 'tasks', component: TaskDashboardComponent},
        ]
    }
];

@NgModule({
    imports:[
        RouterModule.forChild(taskRouterConfig)
    ],
    exports: [
        RouterModule
    ]
})
export class TaskRoutingModule{}