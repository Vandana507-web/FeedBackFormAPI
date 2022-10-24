import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable,throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class HttpsProviderService {

  private apiServer = "https://localhost:7000/api";
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }
  constructor(private httpClient: HttpClient) { }

  create(data:any): Observable<any> {
    return this.httpClient.post<any>(this.apiServer + '/FeedbackForm', JSON.stringify(data), this.httpOptions)
    .pipe(
      catchError(this.errorHandler)
    )
  }
  getById(id:number): Observable<any> {
    return this.httpClient.get<any>(this.apiServer + '/FeedbackForm/' + id)
    .pipe(
      catchError(this.errorHandler)
    )
  }

  getAll(): Observable<any> {
    return this.httpClient.get<any>(this.apiServer + '/FeedbackForm')
    .pipe(
      catchError(this.errorHandler)
    )
  }

  update(id:number, data:any): Observable<any> {
    return this.httpClient.put<any>(this.apiServer + '/FeedbackForm/' + id, JSON.stringify(data), this.httpOptions)
    .pipe(
      catchError(this.errorHandler)
    )
  }

  delete(id:number){
    return this.httpClient.delete(this.apiServer + '/FeedbackForm/' + id, this.httpOptions)
    .pipe(
      catchError(this.errorHandler)
    )
  }
  errorHandler(error:any) {
     let errorMessage = '';
     if(error.error instanceof ErrorEvent) {
       // Get client-side error
       errorMessage = error.error.message;
     } else {
       // Get server-side error
       errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
     }
     console.log(errorMessage);
     return throwError(errorMessage);
  }
}
