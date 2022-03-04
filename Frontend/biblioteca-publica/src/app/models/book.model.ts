import { BooksList } from './books-list-model';

export interface Books {
  total: number;
  books: Array<BooksList>;
}
