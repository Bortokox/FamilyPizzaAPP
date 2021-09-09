import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Pizza } from '../Models/Pizza';
import { PizzaServiceService } from '../services/pizza-service.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss']
})
export class NavComponent implements OnInit {
  pizzas: Pizza[];
  constructor(private router: Router, private service: PizzaServiceService) { }

  ngOnInit(): void {
    this.service.getPizzas().subscribe(pizzas => {
      this.pizzas = pizzas;
    });
  }

}
