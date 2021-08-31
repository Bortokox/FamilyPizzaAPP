import {

  HttpEvent,

  HttpInterceptor,

  HttpHandler,

  HttpRequest,

  HttpResponse,

  HttpErrorResponse

} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

import { Observable, throwError } from 'rxjs';

import { retry, catchError } from 'rxjs/operators';
@Injectable()
export class HttpErrorInterceptor implements HttpInterceptor {
  constructor(private toastr: ToastrService) { }
  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {

    return next.handle(request)

      .pipe(

        retry(1),

        catchError((error: HttpErrorResponse) => {

          let errorMessage: string;

          if (error.error instanceof ErrorEvent) {

            errorMessage = error.error.message;
            ;

          } else {
            errorMessage = error.message + ' status: ' + error.status.toString();
          }

          this.toastr.error(errorMessage);

          return throwError(errorMessage);

        })

      )

  }

}