import { Component, OnInit } from '@angular/core';
import { Course } from 'src/app/models/Course';
import { CourseDetails } from 'src/app/models/CourseDetails';
import { CourseService } from 'src/app/services/course.service';

@Component({
  selector: 'app-courses',
  templateUrl: './courses.component.html',
  styleUrls: ['./courses.component.css']
})
export class CoursesComponent implements OnInit {

  courses: Course[] | undefined;
  courseDetails: CourseDetails | undefined;

  constructor(private courseService: CourseService) { }

  ngOnInit(): void {
    this.courseService.getCourses().subscribe((response: Course[]) => {
        this.courses = response;
    });
  }

  chooseCourse(courseId: string): void {
    this.courseService.getCourse(courseId).subscribe((response: CourseDetails) => {
        this.courseDetails = response;
    });
  }

}
