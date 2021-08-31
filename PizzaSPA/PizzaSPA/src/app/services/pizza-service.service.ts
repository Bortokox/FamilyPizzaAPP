import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Pizza, PizzaDescriptionDTO } from '../Models/Pizza';
import { SuggestedPizza } from '../Models/suggested-pizza';

@Injectable({
  providedIn: 'root'
})
export class PizzaServiceService {
  pizzaModel: Pizza;
  pizzaDtoModel: PizzaDescriptionDTO;
  suggestedPizza: SuggestedPizza;
  error: string;
  url = environment.apiUrl;
  constructor(private http: HttpClient) { }

  getPizzas() {
    return this.http.get<Pizza[]>(this.url + 'Pizzas');
  }
  getPizza(id: number) {
    return this.http.get<PizzaDescriptionDTO>(this.url + 'Pizzas/' + id);
  }
  addLikeOrDislike(pizza: PizzaDescriptionDTO) {
    return this.http.put<PizzaDescriptionDTO>(this.url + 'Pizzas/' + pizza.id, pizza).subscribe(data => {
      this.pizzaDtoModel = data;
    }, error => {
      this.error = error;
    });
  }
  addNewPizza(newPizza: SuggestedPizza) {
    return this.http.post<SuggestedPizza>(this.url + 'Pizzas/', newPizza).subscribe(data => {
      this.suggestedPizza = data;
    }, error => {
      this.error = error;
    });
  }
  getSuggestedPizzas() {
    return this.http.get<SuggestedPizza[]>(this.url + 'SuggestedPizzas');
  }
}
