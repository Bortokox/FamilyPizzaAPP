import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { SuggestedPizza } from '../Models/suggested-pizza';


@Component({
  selector: 'app-suggested-pizza',
  templateUrl: './suggested-pizza.component.html',
  styleUrls: ['./suggested-pizza.component.scss']
})
export class SuggestedPizzaComponent implements OnInit {
  dataSource: SuggestedPizza[];

  displayedColumns: string[] = ['name', 'prizeforsmall', 'prizeforlarge', 'ingridients', 'description'];
  suggestedPizzas: any[];
  constructor(private act: ActivatedRoute) { }

  ngOnInit(): void {
    this.suggestedPizzas = this.act.snapshot.data['suggest'];
    this.dataSource = this.suggestedPizzas;
  }

}
