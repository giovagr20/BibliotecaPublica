using BibliotecaPublica.API.DTO;

namespace BibliotecaPublica.API.Services
{
    public interface IBookService
    {
        BookDTO createBookAsync(BookDTO book);
    }
}
