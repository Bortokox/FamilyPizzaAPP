import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Comments } from '../Models/comments';
import { CommentsServiceService } from '../services/comments.service';

@Component({
  selector: 'app-comments',
  templateUrl: './comments.component.html',
  styleUrls: ['./comments.component.scss']
})
export class CommentsComponent implements OnInit {
  comments: any[];
  commentForm: any;
  dataSource: Comments[];
  displayedColumns: string[] = ['Komentarz', 'Iniciał', 'DataDodania'];
  constructor(private act: ActivatedRoute, private fb: FormBuilder, private toastr: ToastrService, private service: CommentsServiceService, private router: Router) {
    this.commentForm = this.fb.group({
      comment: ['', [Validators.required, Validators.minLength(2)]],
      initials: [''],
    })
  }

  ngOnInit(): void {
    this.comments = this.act.snapshot.data['com'];
    this.dataSource = this.comments;
  }

  addNewComment() {
    if (this.commentForm.valid) {
      let newComment: any = this.commentForm.value;
      this.service.addComment(newComment);
      this.toastr.success('Komentarz dodany', 'Dziękujemy za Twoją sugestie :)');
      this.formReset();
    } else {
      this.toastr.warning('Najpierw musisz uzupełnić wszystkie pola');
    }
  }
  formReset() {
    this.commentForm.reset();
    this.router.navigate(['com/'])
      .then(() => {
        window.location.reload();
      });
  }
}
