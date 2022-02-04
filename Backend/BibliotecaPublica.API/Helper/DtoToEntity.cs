using BibliotecaPublica.API.DTO;
using BibliotecaPublica.API.Entities;

namespace BibliotecaPublica.API.Helper
{
    public class DtoToEntity : IDtoToEntity
    {
        public AuthorEntity authorDtoToEntity(AuthorDTO authorDTO)
        {
            if (authorDTO == null)
            {
                throw new ArgumentNullException(nameof(authorDTO));
            }

            AuthorEntity entity = new AuthorEntity()
            {
                nombre = authorDTO.nombre,
                ciudad = authorDTO.ciudad,
                correo = authorDTO.correo,
                fechaNacimiento = authorDTO.fechaNacimiento
            };

            return entity; 
        }

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
