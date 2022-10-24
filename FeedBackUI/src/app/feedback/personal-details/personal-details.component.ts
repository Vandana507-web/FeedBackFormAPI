import { Component, Input, OnInit } from '@angular/core';
import { FormGroup ,FormControl, Validators ,FormBuilder} from '@angular/forms';

@Component({
  selector: 'app-personal-details',
  templateUrl: './personal-details.component.html',
  styleUrls: ['./personal-details.component.css']
})
export class PersonalDetailsComponent implements OnInit {
  myForm!: FormGroup;
 
  createForm() {
   this.myForm = this.fb.group({
      username: ['', Validators.required ]
   });
 }
formBuilder !:FormBuilder

feedBackForm! : FormGroup;
  @Input() form!:FormGroup;
    constructor(private fb:FormBuilder) { 
      this.createForm();
    }

  ngOnInit(): void {
   
    
    
  }

step1Submit(){
  this.form.get('personalDetail')!.get('userName')!.markAllAsTouched;
  this.form.get('personalDetail')!.get('userName')!.updateValueAndValidity;
  this.form.get('personalDetail')!.get('email')!.markAllAsTouched;
  this.form.get('personalDetail')!.get('email')!.updateValueAndValidity;
  this.form.get('personalDetail')!.get('phoneNo')!.markAllAsTouched;
  this.form.get('personalDetail')!.get('phoneNo')!.updateValueAndValidity;
}
get perSonalDetailsControl(){
  return ((this.form.get('personalDetail') as FormGroup).controls)
  }

}
