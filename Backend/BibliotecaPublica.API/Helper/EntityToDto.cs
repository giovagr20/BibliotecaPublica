using BibliotecaPublica.API.DTO;
using BibliotecaPublica.API.Entities;

namespace BibliotecaPublica.API.Helper
{
    public class EntityToDto : IEntityToDto
    {
        public BookDTO bookEntityToDto(BookEntity bookEntity)
        {
            if (bookEntity == null)
            {
                throw new ArgumentNullException(nameof(bookEntity));
            }

                BookDTO bookDTO = new BookDTO
                {
                    titulo = bookEntity.titulo,
                    anio = bookEntity.anio,
                    genero = bookEntity.genero,
                    numeroPaginas = bookEntity.numeroPaginas
                };

                return bookDTO;
        }
    }
}
