import {  ComponentFixture, TestBed } from '@angular/core/testing';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { PersonalDetailsComponent } from './personal-details.component';
import { DebugElement } from '@angular/core';
import { BrowserModule,By } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CommonModule } from '@angular/common';
import { MatModule } from 'src/app/mat.module';
import { FeedbackformComponent } from '../feedbackform/feedbackform.component';
import { CdkStepper } from '@angular/cdk/stepper';
import { HttpClient } from '@angular/common/http';

describe('PersonalDetailsComponent', () => {
  let component: PersonalDetailsComponent;
  let component1: FeedbackformComponent;
  let fixture: ComponentFixture<PersonalDetailsComponent>;
  let de:DebugElement;
  let el: HTMLElement;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FeedbackformComponent,PersonalDetailsComponent ],
      imports:[FormsModule,ReactiveFormsModule,MatModule,BrowserAnimationsModule,BrowserModule,CommonModule],
      providers:[CdkStepper,HttpClient]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PersonalDetailsComponent);
    component = fixture.componentInstance;
    component.form=new FormGroup({
      personalDetail: new FormGroup({
        userName: new FormControl(null, [Validators.required]),
        email: new FormControl(null, [Validators.required, Validators.email]),
        phoneNo: new FormControl(null, [
          Validators.required,
          Validators.pattern('^((\\+91-?)|0)?[0-9]{10}$'),
        ])
      })
    });
    fixture.detectChanges();
  });

  it('should create', () => {
    fixture.detectChanges();
    expect(component).toBeTruthy();
  });

  it(`form should be invalid`, () => {

    (component.form.get('personalDetail') as FormGroup).controls['userName'].setValue('');
    (component.form.get('personalDetail') as FormGroup).controls['email'].setValue('');
    (component.form.get('personalDetail') as FormGroup).controls['phoneNo'].setValue('');
    expect((component.form.get('personalDetail') as FormGroup).valid).toBeFalsy();
  });

  it(`form should be Valid`, () => {
    (component.form.get('personalDetail') as FormGroup).controls['userName'].setValue('SACHIN');
    (component.form.get('personalDetail') as FormGroup).controls['email'].setValue('sachin19927@gmail.com');
    (component.form.get('personalDetail') as FormGroup).controls['phoneNo'].setValue('9035997204');
    expect((component.form.get('personalDetail') as FormGroup).valid).toBeTruthy();
  });


  it(`form should be `, () => {
    (component.form.get('personalDetail') as FormGroup).controls['userName'].setValue('SACHIN');
    (component.form.get('personalDetail') as FormGroup).controls['email'].setValue('sachin19927@gmail.com');
    (component.form.get('personalDetail') as FormGroup).controls['phoneNo'].setValue('9035');
    expect((component.form.get('personalDetail') as FormGroup).valid).toBeFalse();
  });


});