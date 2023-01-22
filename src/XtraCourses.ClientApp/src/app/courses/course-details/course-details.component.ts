import { Component, Input, OnChanges, OnInit } from '@angular/core';
import { CourseDetails } from 'src/app/models/CourseDetails';

@Component({
  selector: 'app-course-details',
  templateUrl: './course-details.component.html',
  styleUrls: ['./course-details.component.css']
})
export class CourseDetailsComponent implements OnChanges {

  @Input() courseDetails: CourseDetails | undefined;
  constructor() { }

  ngOnChanges() {
    console.log(this.courseDetails)
  }

}
