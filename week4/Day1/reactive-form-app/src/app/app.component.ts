import { Component } from '@angular/core';
import {FormGroup,FormControl,FormControlName} from '@angular/forms'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'reactive-form-app';
  loginForm =  new FormGroup({
    userFName:new FormControl(''),
    userLFName:new FormControl(''),
    userEmail:new FormControl(''),
    password:new FormControl(''),
  
  }  )
  loginUser()
  {
    console.warn(this.loginForm.value)
  }
}
