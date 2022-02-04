using BibliotecaPublica.API.DTO;

namespace BibliotecaPublica.API.Services
{
    public interface IBookService
    {
        Task<int> createBookAsync(BookDTO book);

        Task<BookDTO> GetBookAsync(int id);

        IEnumerable<BookDTO> GetBooksAsync();
    }
}
