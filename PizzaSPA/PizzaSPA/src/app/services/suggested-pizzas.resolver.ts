import { Injectable } from '@angular/core';
import {
  Router, Resolve,
  RouterStateSnapshot,
  ActivatedRouteSnapshot
} from '@angular/router';
import { Observable, of } from 'rxjs';
import { SuggestedPizza } from '../Models/suggested-pizza';
import { PizzaServiceService } from './pizza-service.service';

@Injectable({
  providedIn: 'root'
})
export class SuggestedPizzasResolver implements Resolve<SuggestedPizza[]> {
  pizza: SuggestedPizza;
  constructor(private pizzaService: PizzaServiceService) {

  }
  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<SuggestedPizza[]> {
    return this.pizzaService.getSuggestedPizzas();
  }
}
