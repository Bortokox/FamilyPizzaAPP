import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CommentsComponent } from './comments/comments.component';
import { CreatePizzaComponent } from './create-pizza/create-pizza.component';
import { DetailsComponentComponent } from './details-component/details-component.component';
import { HomeComponentComponent } from './home-component/home-component.component';
import { CommentsResolver } from './services/comments.resolver';
import { PizzaResolver } from './services/pizza.resolver';
import { SuggestedPizzasResolver } from './services/suggested-pizzas.resolver';
import { SuggestedPizzaComponent } from './suggested-pizza/suggested-pizza.component';
import { WelcomeComponent } from './welcome/welcome.component';

const routes: Routes = [
  {
    path: '', component: WelcomeComponent
  },
  {
    path: 'nav', component: HomeComponentComponent, resolve: {
      nav: PizzaResolver
    }
  },
  {
    path: 'nav/:id', component: DetailsComponentComponent
  },
  {
    path: 'create', component: CreatePizzaComponent
  },
  {
    path: 'suggest', component: SuggestedPizzaComponent, resolve: {
      suggest: SuggestedPizzasResolver
    }
  },
  {
    path: 'com', component: CommentsComponent, resolve: {
      com: CommentsResolver
    }
  },
  {
    path: '**', component: WelcomeComponent, pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
