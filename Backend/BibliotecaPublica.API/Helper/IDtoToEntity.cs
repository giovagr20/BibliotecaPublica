using BibliotecaPublica.API.Entities;
using BibliotecaPublica.API.DTO;

namespace BibliotecaPublica.API.Helper
{
    public interface IDtoToEntity
    {
        BookEntity bookDtoToEntity(BookDTO bookDTO);
    }
}
