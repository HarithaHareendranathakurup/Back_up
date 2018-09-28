import { Component, OnInit,Inject } from '@angular/core';
import { UserService } from "../shared/user.service";
import { HttpErrorResponse } from "@angular/common/http";
import {Router} from "@angular/router";
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material';
import {ToastrService} from 'ngx-toastr';
import Swal from 'sweetalert2';
import {DialogData} from '../reset-password/reset-password.component';

@Component({
  selector: 'app-confirm',
  templateUrl: './confirm.component.html',
  styleUrls: ['./confirm.component.css']
})
export class ConfirmComponent implements OnInit {

  

  ngOnInit() {
  }
//injects data into the 
//dialog box, and sends data back upon when
// user clicks away from box
constructor(
  public dialogRef: MatDialogRef<ConfirmComponent>,
  @Inject(MAT_DIALOG_DATA) public data: DialogData) {}
  onNoClick(): void {
  this.dialogRef.close();
  }
  
  } 

