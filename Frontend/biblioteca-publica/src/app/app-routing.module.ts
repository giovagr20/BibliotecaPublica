import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthorComponent } from './components/author/author.component';
import { BookComponent } from './components/book/book.component';

const routes: Routes = [
  {
    path: 'books',
    component: BookComponent,
  },
  {
    path: '',
    redirectTo: 'books',
    pathMatch: 'full',
  },
  {
    path: 'author',
    component: AuthorComponent,
  },
  { path: '**', redirectTo: 'books' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
