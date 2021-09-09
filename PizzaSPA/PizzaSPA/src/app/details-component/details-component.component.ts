import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Pizza, PizzaDescriptionDTO } from '../Models/Pizza';
import { PizzaServiceService } from '../services/pizza-service.service';

@Component({
  selector: 'app-details-component',
  templateUrl: './details-component.component.html',
  styleUrls: ['./details-component.component.scss']
})
export class DetailsComponentComponent implements OnInit {
  pizza: PizzaDescriptionDTO;
  id: any;
  clicked = false;
  constructor(private pizzaService: PizzaServiceService, private router: ActivatedRoute, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.id = this.router.snapshot.paramMap.get('id');
    this.loadPizza();
  }

  loadPizza() {
    this.pizzaService.getPizza(this.id).subscribe(pizza => {
      this.pizza = pizza;
    });
  }
  likeRise() {
    this.pizza.like++;
    this.pizzaService.addLikeOrDislike(this.pizza);
    this.toastr.success('Dziękujemy :)', 'Zapraszamy do lokalu :)');
  }
  dislikeRise() {
    this.pizza.dislike++;
    this.pizzaService.addLikeOrDislike(this.pizza);
    this.toastr.info('Przykro nam :(', 'Czekamy na Ciebie w pizzeri, żeby Ci pokazac że sie mylisz :(');
  }
}
