import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Job } from './job.model';
import { EMPTY, Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { MatSnackBar } from '@angular/material/snack-bar';

@Injectable({
  providedIn: 'root'
})
export class JobService {
  baseUrl = "http://localhost:12446/api/jobs";


  constructor( private snackBar: MatSnackBar, private http: HttpClient) { }

  showMessage(msg: string, isError: boolean = false): void {
    // this.snackBar.open(msg, "X", {
    //   duration: 3000,
    //   horizontalPosition: "right",
    //   verticalPosition: "top",
    //   panelClass: isError ? ["msg-error"] : ["msg-success"],
    // });
  }

  read(): Observable<Job[]> {
    return this.http.get<Job[]>(this.baseUrl).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }


  errorHandler(e: any): Observable<any> {
    this.showMessage("An error has occurred while fetching!", true);
    return EMPTY;
  }
 
}
