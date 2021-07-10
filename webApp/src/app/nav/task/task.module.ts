import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { UserPanelComponent } from "../userPanel/uerPanel.component";
import { TaskDashboardComponent } from "./tasdk-dashboard/task-dashboard.component";
import { TaskAppComponent } from "./task.app.component";
import { TaskRoutingModule } from "./task.route";
import { MatTabsModule } from '@angular/material/tabs';

@NgModule({
    declarations: [
        TaskAppComponent,
        TaskDashboardComponent
    ],
    imports: [
        CommonModule,
        TaskRoutingModule,
        MatTabsModule
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