import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Comments } from '../Models/comments';


@Injectable({
  providedIn: 'root'
})
export class CommentsServiceService {
  comment: Comments;
  error: string;
  url = environment.apiUrl;
  constructor(private http: HttpClient) { }

  getComments() {
    return this.http.get<Comments[]>(this.url + 'Comments');
  }
  addComment(newComment: Comments) {
    return this.http.post<Comments>(this.url + 'Comments/', newComment).subscribe(data => {
      this.comment = data;
    }, error => {
      this.error = error;
    });
  }
}
