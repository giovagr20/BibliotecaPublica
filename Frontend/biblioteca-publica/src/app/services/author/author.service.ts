import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
import { Books } from 'src/app/models/book.model';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthorService {

  private host: string = environment.localBack; 

  constructor(private http: HttpClient ) { }


}
