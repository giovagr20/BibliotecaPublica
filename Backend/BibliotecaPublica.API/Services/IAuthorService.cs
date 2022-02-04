using BibliotecaPublica.API.DTO;

namespace BibliotecaPublica.API.Services
{
    public interface IAuthorService
    {
        Task<int> createAuthorAsync(AuthorDTO book);

        Task<AuthorDTO> getAuthorById(int id);

        Task<IAsyncEnumerable<AuthorDTO>> getAllAuthorAsync();
    }
}
