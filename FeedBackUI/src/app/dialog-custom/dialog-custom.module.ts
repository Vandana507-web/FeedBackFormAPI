import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ConfirmationDialog } from './confirmation-dialog/confirmation-dialog.component';
import { AlertDialogComponent } from './alert-dialog/alert-dialog.component';
import { MatModule } from '../mat.module';



@NgModule({
  declarations: [
    ConfirmationDialog,
    AlertDialogComponent
  ],
  imports: [
    CommonModule,
    MatModule
  ]
})
export class DialogCustomModule { }
