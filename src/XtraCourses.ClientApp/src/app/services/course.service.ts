import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable } from "rxjs";
import { Course } from "../models/Course";
import { environment } from "src/environments/environment";
import { CourseDetails } from "../models/CourseDetails";

@Injectable({
    providedIn: 'root',
})
export class CourseService{
    baseUrl: string;

    constructor(private httpClient: HttpClient){
        this.baseUrl = environment.apiUrl;
    }

    getCourses() : Observable<Course[]>{
        return this.httpClient.get<Course[]>(this.baseUrl + 'courses');
    }

    getCourse(courseId: string) : Observable<CourseDetails>{
        return this.httpClient.get<CourseDetails>(this.baseUrl + "courses/" + courseId);
    }
}