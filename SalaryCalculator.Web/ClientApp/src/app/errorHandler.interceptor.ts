
import { HttpErrorResponse, HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';



@Injectable()
export class ErrorHandlingInterceptor implements HttpInterceptor {
  constructor(
  ) {}

  intercept(
    request: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    
    return next.handle(request).pipe(
      catchError((err: HttpErrorResponse) => {
            let message = "oops, something went wrong"
            
            message = err.error ? err.error || err.error.message || err.error.title  : message;
            return throwError(message);
        })
    )
  }
}