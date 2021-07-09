import { AfterViewInit, Component, ElementRef, OnInit, ViewChildren } from "@angular/core";
import { FormBuilder, FormControlName, Validators } from "@angular/forms";
import { User } from "./models/user";
import {DisplayMessage, GenericValidator, ValidationMessages} from "../shared/generic-forms";
import { fromEvent, merge, Observable } from "rxjs";
import { Router } from "@angular/router";

@Component({
    selector: 'login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit, AfterViewInit {

    @ViewChildren(FormControlName, {read: ElementRef}) formInputElements: ElementRef[] = [];

    validationMessages :ValidationMessages = {};
    displayMessage: DisplayMessage = {};
    genericValidator: GenericValidator;

    mudancasNaoSalvas: boolean = false;
    isNewUser: boolean = false;

    registerFormRender: boolean = false;

    user: User = {} as User;
    constructor(private fb: FormBuilder, private router : Router){
        this.validationMessages = {
            email:{
                required: 'O email é requerido',
                minlength: 'O email precisa ter no minimo 2 caracters'
            },
            password: {
                required: 'Informe o a senha',
            },
            confirmPassword: {
                required: 'Necessaria confirmação de senha'
            }
        };

        this.genericValidator = new GenericValidator(this.validationMessages);
    }

    loginForm = this.fb.group({
        email: ['', [Validators.required, Validators.minLength(2)]],
        password: ['', Validators.required]
    });

    registerForm = this.fb.group({
        email: ['', [Validators.required, Validators.minLength(2)]],
        password: ['', Validators.required],
        confirmPassword: ['', Validators.required]
    });

    ngOnInit(): void {
        
    }

    private generate(formGroup: any): void{
        let controlBlurs: Observable<any>[] = this.formInputElements.map((formControl: ElementRef) => 
        fromEvent(formControl.nativeElement, 'blur'));

        merge(...controlBlurs).subscribe(() => {
            this.displayMessage = this.genericValidator.processarMensagens(formGroup);
            this.mudancasNaoSalvas = true;
        });
    }

    ngAfterViewInit(): void {
        this.generate(this.loginForm);
    }

    login(){
        if(this.loginForm.valid){
            Object.assign(this.user, this.loginForm.value);
            this.router.navigate(['home']);
        }
    }

    register(){
        if(this.registerForm.valid){

        }
    }

    changeToNewUser(){
        this.timeoutForm(this.registerForm, true);
        //in case to clean the html errors, just clean the 'displayMessage'
    }

    changeLoginUser(){
        this.timeoutForm(this.loginForm, false);
        //in case to clean the html errors, just clean the 'displayMessage'
    }

    timeoutForm(form:any, isNewUser: boolean){
        let loginBox = document.getElementById("loginBox");
        if(loginBox){
            loginBox.style.marginLeft = '100em';
            loginBox.style.opacity = '0';
        }
        
        setTimeout(()=>{ 
            this.isNewUser = isNewUser;
            this.generate(form);
        }, 500);
    }
}