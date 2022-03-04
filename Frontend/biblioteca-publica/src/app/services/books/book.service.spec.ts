import { TestBed } from '@angular/core/testing';
import { Observable } from 'rxjs';
import { Books } from 'src/app/models/book.model';
import { BookService } from './book.service';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { HttpClient } from '@angular/common/http';

describe('BookService', () => {
  let service: BookService;
  let httpClientSpy: jasmine.SpyObj<HttpClient>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    });
    service = TestBed.inject(BookService);
    httpClientSpy = jasmine.createSpyObj('HttpClient', ['get']);
    service = new BookService(httpClientSpy);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
