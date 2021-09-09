import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SuggestedPizzaComponent } from './suggested-pizza.component';

describe('SuggestedPizzaComponent', () => {
  let component: SuggestedPizzaComponent;
  let fixture: ComponentFixture<SuggestedPizzaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SuggestedPizzaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SuggestedPizzaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
