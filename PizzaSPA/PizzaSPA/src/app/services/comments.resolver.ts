import { Injectable } from '@angular/core';
import {
  Router, Resolve,
  RouterStateSnapshot,
  ActivatedRouteSnapshot
} from '@angular/router';
import { Observable, of } from 'rxjs';
import { Comments } from '../Models/comments';
import { CommentsServiceService } from './comments.service';

@Injectable({
  providedIn: 'root'
})
export class CommentsResolver implements Resolve<Comments[]> {
  comments: Comments;
  constructor(private service: CommentsServiceService) {

  }
  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Comments[]> {
    return this.service.getComments();
  }
}
