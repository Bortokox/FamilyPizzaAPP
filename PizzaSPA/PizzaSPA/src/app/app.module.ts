import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavComponent } from './nav/nav.component';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatDividerModule } from '@angular/material/divider';
import { MatIconModule } from '@angular/material/icon';
import { PizzaServiceService } from './services/pizza-service.service';
import { HomeComponentComponent } from './home-component/home-component.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { DetailsComponentComponent } from './details-component/details-component.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { ToastrModule } from 'ngx-toastr';
import { CreatePizzaComponent } from './create-pizza/create-pizza.component';
import { SuggestedPizzaComponent } from './suggested-pizza/suggested-pizza.component';
import { CommentsComponent } from './comments/comments.component';
import { ReactiveFormsModule } from '@angular/forms';
import { MatTableModule } from '@angular/material/table'
import { HttpErrorInterceptor } from './interceptors/http-error.interceptor';
import { CommentsServiceService } from './services/comments.service';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponentComponent,
    DetailsComponentComponent,
    WelcomeComponent,
    WelcomeComponent,
    CreatePizzaComponent,
    SuggestedPizzaComponent,
    CommentsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatTableModule,
    MatButtonModule,
    MatCardModule,
    MatInputModule,
    MatToolbarModule,
    MatDividerModule,
    MatIconModule,
    HttpClientModule,
    ToastrModule.forRoot(),
    ReactiveFormsModule
  ],
  providers: [PizzaServiceService, CommentsServiceService,
    {
      provide: HTTP_INTERCEPTORS,

      useClass: HttpErrorInterceptor,

      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
