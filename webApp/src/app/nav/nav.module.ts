import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { RouterModule } from "@angular/router";
import { LoginComponent } from "./login/login.component";
import { ReactiveFormsModule } from "@angular/forms";
import { UserPanelComponent } from "./userPanel/uerPanel.component";
import { TaskModule } from "./task/task.module";
import { HomeComponent } from "./menu/home.component";
import { EditTaskComponent } from "./task/edit-task/edit-task.component";

@NgModule({
    declarations: [
        LoginComponent,
        UserPanelComponent,
        HomeComponent,
        EditTaskComponent
    ],
    imports: [
        ReactiveFormsModule,
        CommonModule,
        RouterModule,
        TaskModule
    ],
    exports: []
})
export class NavegacaoModule {}