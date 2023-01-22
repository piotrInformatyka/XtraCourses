import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { CoursesComponent } from './courses/coursesList/courses.component';
import { CourseDetailsComponent } from './courses/course-details/course-details.component';

@NgModule({
  declarations: [
    AppComponent,
    CoursesComponent,
    CourseDetailsComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
