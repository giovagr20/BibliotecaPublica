import { Component, Input, OnInit, Output } from '@angular/core';
import { Books } from 'src/app/models/book.model';
import { BookService } from 'src/app/services/books/book.service';
import Swal from 'sweetalert2';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.sass'],
})
export class BookComponent implements OnInit {
  @Input('name') name: string = '';
  @Output('same') same: string = '';
  constructor(
    private bookServices: BookService,
    private modalService: NgbModal
  ) {}

  books!: Books[];
  bookEntry!: Books;
  nameBook = '';

  ngOnInit(): void {
    setTimeout(() => {
      this.bookServices.getBooks().subscribe(
        (response) => {
          this.bookEntry = response;
        },
        (error) => {
          this.handleError(error);
        }
      );
    }, 2000);
  }

  async createBookModal() {
    const swalWithBootstrapButtons = Swal.mixin({
      customClass: {
        confirmButton: 'btn btn-success',
        cancelButton: 'btn btn-danger',
      },
      buttonsStyling: false,
    });

    await swalWithBootstrapButtons
      .fire({
        title: 'Agrega un nuevo libro',
        html:
          '<strong>Titulo: </strong><input id="swal-titulo" class="swal2-input"> <br>' +
          '<strong>Año: </strong><input id="swal-anio" class="swal2-input"> <br>' +
          '<strong>Genero: </strong><input id="swal-genero" class="swal2-input"> <br>' +
          '<strong>Paginas: </strong><input id="swal-numeroPaginas" class="swal2-input">',
        focusConfirm: false,
        confirmButtonText: 'Agregar',
      })
      .then((response) => {
        alert('No hay datos');
      });
  }

  createBook(book: Books) {
    this.bookServices.createBook(book).subscribe((response) => {
      if (!response) {
        Swal.fire({
          title: 'Upps! ha ocurrido un error',
          icon: 'error',
          html: 'Por favor vuelve a intentar',
          showConfirmButton: true,
        });

        Swal.fire({
          title: 'Exito',
          html: 'Se ha guardado la información correctamente',
          icon: 'success',
        });
      }
    });
  }

  getBookById(book: any) {
    this.bookServices.getBookById(book).subscribe((response) => {
      if (!response)
        Swal.fire({
          title: 'Upps! ha ocurrido un error',
          icon: 'error',
          html: 'Por favor vuelve a intentar',
          showConfirmButton: true,
        });
      else this.bookEntry = response;
    });
  }

  async handleError(error: any) {
    await Swal.fire({
      title: 'Upps! ha ocurrido un error',
      icon: 'error',
      html: 'Por favor vuelve a intentar',
      showConfirmButton: true,
    });
  }
}
