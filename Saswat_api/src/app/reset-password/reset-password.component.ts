import { Component, OnInit, Inject } from '@angular/core';
import { UserService } from "../shared/user.service";
import { HttpErrorResponse } from "@angular/common/http";
import {Router} from "@angular/router";
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material';
import {ToastrService} from 'ngx-toastr';
import Swal from 'sweetalert2';
import {ConfirmComponent} from '../confirm/confirm.component';


export interface DialogData {
 //resetCode: string;
 newPassword:string;
 resetEmail: string;
}

@Component({
  selector: 'app-reset-password',
  templateUrl: './reset-password.component.html',
  styleUrls: ['./reset-password.component.css']
})

export class ResetPasswordComponent {
  resetCode : string;
  newPassword : string;
  resetEmail : string;
  constructor(
    private userServ : UserService,
    private router : Router,
    private dialog: MatDialog, 
    private toast:ToastrService) {}

  //calls the uservice to send the confirmation code for the user to reset their password
  onSubmit(userEmail){  
      sessionStorage.setItem('userEmail',userEmail);   
      //calls the service to send the user's Confirmation Code
      this.userServ.sendCode(userEmail).subscribe((data : any)=>{      
      this.resetEmail = userEmail;
      this.resetCode = data;
      //display success message if email is excepted, otherwise, show fail message
      Swal({
        position: 'center',
        type: 'success',
        title: 'Email Sent',
        text: 'DO NOT LEAVE THIS PAGE: Check your email for your confirmation code',
        showConfirmButton: false,
        timer: 6000
      }) 
    },(err : HttpErrorResponse)=>{
      Swal({
        position: 'center',
        type: 'error',
        title: 'Invalid Email',
        text: 'The email you provided was not found, please try again',
        showConfirmButton: false,
        timer: 6000
      })
    }); 
    
  }

  PasswordReset(myCode)
  {
    if(myCode == this.resetCode){
        const dialogRef = this.dialog.open(ConfirmComponent, {
        width: '250px',
        data: { newPassword : this.newPassword}
          });

        dialogRef.afterClosed().subscribe(result => {
           //show success message once dialog box is closed
          //console.log('The dialog was closed');
              this.newPassword = result;
              alert(result);
           this.userServ.resetPassword(this.resetEmail, this.newPassword).subscribe((data : any)=>{ 
              Swal({
              position: 'center',
              type: 'success',
              title: 'Password Set',
              text: 'Your Password is now ' + result,
              showConfirmButton: false,
              timer: 6000
              })        
            },(err : HttpErrorResponse)=>{
              Swal({
              position: 'center',
              type: 'error',
              title: 'ResetFailed',
              text: 'Your Password was not excepted, you must re-enter your email, and try again',
              showConfirmButton: false,
              timer: 6000
              })
              });
          });
    }
    else{
      Swal({
      position: 'center',
      type: 'error',
      title: 'Invaild Code',
      text: 'You will have to reenter your email to recieve a new code',
      showConfirmButton: false,
      timer: 4000
        })
    }    
  }


}




