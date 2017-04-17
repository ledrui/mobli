/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { MakeServiceService } from './make-service.service';

describe('MakeServiceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [MakeServiceService]
    });
  });

  it('should ...', inject([MakeServiceService], (service: MakeServiceService) => {
    expect(service).toBeTruthy();
  }));
});
