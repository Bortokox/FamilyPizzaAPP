import { Injectable } from '@angular/core';
import {
  Router, Resolve,
  RouterStateSnapshot,
  ActivatedRouteSnapshot
} from '@angular/router';
import { Observable, of } from 'rxjs';
import { Pizza, PizzaDescriptionDTO } from '../Models/Pizza';
import { PizzaServiceService } from './pizza-service.service';

@Injectable({
  providedIn: 'root'
})
export class PizzaResolver implements Resolve<Pizza[]> {
  pizza: PizzaDescriptionDTO;
  constructor(private pizzaService: PizzaServiceService) {

  }
  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Pizza[]> {
    return this.pizzaService.getPizzas();
  }
}
