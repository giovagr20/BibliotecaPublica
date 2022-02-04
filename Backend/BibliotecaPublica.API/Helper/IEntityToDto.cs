using BibliotecaPublica.API.Entities;
using BibliotecaPublica.API.DTO;

namespace BibliotecaPublica.API.Helper
{
    public interface IEntityToDto
    {
        BookDTO bookEntityToDto(BookEntity bookEntity);

        AuthorDTO authorEntityToDto(AuthorEntity authorEntity);

    }
}
