import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { PizzaServiceService } from '../services/pizza-service.service';
import { Validators } from '@angular/forms'
import { SuggestedPizza } from '../Models/suggested-pizza';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-create-pizza',
  templateUrl: './create-pizza.component.html',
  styleUrls: ['./create-pizza.component.scss']
})
export class CreatePizzaComponent implements OnInit {
  pizzaForm: any;
  constructor(private service: PizzaServiceService, private fb: FormBuilder, private toastr: ToastrService) {
    this.pizzaForm = this.fb.group({
      name: ['', [Validators.required, Validators.minLength(2)]],
      ingridients: ['', [Validators.required]],
      description: ['', [Validators.required]],
      prizeForSmall: ['', [Validators.required, Validators.pattern("^[0-9]*$")]],
      prizeForLarge: ['', [Validators.required, Validators.pattern("^[0-9]*$")]]
    })
  }

  ngOnInit(): void {

  }
  addNewPizza() {
    if (this.pizzaForm.valid) {
      let newPizza: SuggestedPizza = this.pizzaForm.value;
      this.service.addNewPizza(newPizza);
      this.toastr.success('Nowa pizza stworzona', 'Dziękujemy za Twoją sugestie :)');
      this.formReset();
    } else {
      this.toastr.warning('Najpierw musisz uzupełnić wszystkie pola');
    }
  }
  formReset() {
    this.pizzaForm.reset();
  }
}
