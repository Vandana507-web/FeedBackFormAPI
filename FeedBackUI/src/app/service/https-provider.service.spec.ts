import { TestBed } from '@angular/core/testing';

import { HttpsProviderService } from './https-provider.service';

describe('HttpsProviderService', () => {
  let service: HttpsProviderService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HttpsProviderService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
