using BibliotecaPublica.API.DTO;
using BibliotecaPublica.API.Entities;

namespace BibliotecaPublica.API.Helper
{
    public class DtoToEntity : IDtoToEntity
    {
        public BookEntity bookDtoToEntity(BookDTO bookDTO)
        {

            if (bookDTO == null)
            {
                throw new ArgumentNullException(nameof(bookDTO));
            }

            BookEntity bookEntity = new BookEntity
            {
                titulo = bookDTO.titulo,
                anio = bookDTO.anio,
                genero = bookDTO.genero,
                numeroPaginas = bookDTO.numeroPaginas
            };         

            return bookEntity;
        }
    }
}
