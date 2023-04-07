import { Injectable } from '@angular/core';
import { MatSnackBar } from "@angular/material/snack-bar";
import { HttpClient } from "@angular/common/http";
import { Candidate } from './candidate.model';
import { Observable, EMPTY } from "rxjs";
import { map, catchError } from "rxjs/operators";


@Injectable({
  providedIn: 'root'
})
export class CandidateService {
  baseUrl = "http://localhost:12445/api/candidates";


  constructor( private http: HttpClient) { }

  showMessage(msg: string, isError: boolean = false): void {
    // this.snackBar.open(msg, "X", {
    //   duration: 3000,
    //   horizontalPosition: "right",
    //   verticalPosition: "top",
    //   panelClass: isError ? ["msg-error"] : ["msg-success"],
    // });
  }

  read(): Observable<Candidate[]> {
    return this.http.get<Candidate[]>(this.baseUrl).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  errorHandler(e: any): Observable<any> {
    this.showMessage("An error has occurred!", true);
    return EMPTY;
  }
}
