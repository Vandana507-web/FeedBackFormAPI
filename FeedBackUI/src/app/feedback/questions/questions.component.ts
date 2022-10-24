import {
  Component,
  Input,
  OnChanges,
  OnInit,
  SimpleChanges,
} from '@angular/core';
import { FormGroup } from '@angular/forms';
import { SharedServiceService } from 'src/app/service/shared-service.service';

@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html',
  styleUrls: ['./questions.component.css'],
})
export class QuestionsComponent implements OnInit, OnChanges {
  @Input() form!: FormGroup;
  @Input() questionLabel!: any;
  @Input() queControlName: any;
  @Input() queFormGroup: any;
 
  optionOne = ['Yes', 'No'];
  optionTwo = ['Software Engineering', 'Research Engineering'];

  constructor(private shareedSerice: SharedServiceService) {}

  ngOnChanges(changes: SimpleChanges) {
    // changes.prop contains the old and the new value...
    console.log(this.questionLabel);
  }

  qFourOption!: string[];

  ngOnInit(): void {
   
  }

  change(event: any) {
    console.log('changing event');
    if (this.queFormGroup == 'queThree') {
      this.shareedSerice.topics = [];
      this.shareedSerice.applied = event;
      if (this.shareedSerice.applied === 'Software Engineering') {
        this.shareedSerice.topics = this.shareedSerice.softwareList;
      } else if (this.shareedSerice.applied === 'Research Engineering') {
        this.shareedSerice.topics = this.shareedSerice.researchList;
      }
      console.log(this.shareedSerice.topics);
      this.qFourOption = this.shareedSerice.topics;
    }
  }
 
  loadRepsonse()
  {
    this.qFourOption =this.shareedSerice.topics;
  }
}
