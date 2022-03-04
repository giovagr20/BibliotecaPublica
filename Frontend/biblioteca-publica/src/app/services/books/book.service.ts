import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Books } from 'src/app/models/book.model';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class BookService {
  private host: string = environment.localBack;

  constructor(private http: HttpClient) {}

  createBook(book: Books): Observable<any> {
    return this.http
      .post(`${this.host}api/author`, book)
      .pipe(map((response) => response as any));
  }

  getBooks(): Observable<Books> {
    return this.http
      .get(`${this.host}new`)
      .pipe(map((response) => response as Books));
  }

  getBookById(book: string): Observable<Books> {
    return this.http
      .get(`${this.host}search/${book}`)
      .pipe(map((response) => response as Books));
  }
}
