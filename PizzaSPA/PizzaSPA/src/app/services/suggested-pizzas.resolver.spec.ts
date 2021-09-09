import { TestBed } from '@angular/core/testing';

import { SuggestedPizzasResolver } from './suggested-pizzas.resolver';

describe('SuggestedPizzasResolver', () => {
  let resolver: SuggestedPizzasResolver;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    resolver = TestBed.inject(SuggestedPizzasResolver);
  });

  it('should be created', () => {
    expect(resolver).toBeTruthy();
  });
});
