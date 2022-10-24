import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FeedbackformComponent } from './feedbackform/feedbackform.component';
import { PersonalDetailsComponent } from './personal-details/personal-details.component';
import { PreviewComponent } from './preview/preview.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule ,ReactiveFormsModule} from '@angular/forms';
import { MatModule } from '../mat.module';
import { QuestionsComponent } from './questions/questions.component';





@NgModule({
  declarations: [
    FeedbackformComponent,
    PersonalDetailsComponent,
    PreviewComponent,
    QuestionsComponent
    
  ],
  imports: [
    CommonModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    MatModule

  ]
})
export class FeedbackModule { }
