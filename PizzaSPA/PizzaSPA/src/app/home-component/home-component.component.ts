import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-home-component',
  templateUrl: './home-component.component.html',
  styleUrls: ['./home-component.component.scss']
})
export class HomeComponentComponent implements OnInit {
  pizzas: any[];
  constructor(private act: ActivatedRoute) {

  }

  ngOnInit(): void {
    this.pizzas = this.act.snapshot.data.nav;
  }
}
