import { OnInit } from "@angular/core";
import { Component } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";

@Component({
    selector: 'app-edit-task',
    templateUrl: './edit-task.component.html'
})
export class EditTaskComponent implements OnInit{
    teste: any;
    constructor(
        private route: ActivatedRoute,
        private router: Router
    ){}

    ngOnInit(): void {
        this.route.params
        .subscribe(params => {
          this.teste = params['id'];
        });
    }

}