import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { RouterModule } from "@angular/router";
import { LoginComponent } from "./login/login.component";
import { ReactiveFormsModule } from "@angular/forms";
import { UserPanelComponent } from "./userPanel/uerPanel.component";
import { TaskModule } from "./task/task.module";
import { HomeComponent } from "./menu/home.component";

@NgModule({
    declarations: [
        LoginComponent,
        UserPanelComponent,
        HomeComponent
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