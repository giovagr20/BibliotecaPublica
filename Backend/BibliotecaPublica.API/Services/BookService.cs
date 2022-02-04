using BibliotecaPublica.API.DTO;
using BibliotecaPublica.API.Helper;
using BibliotecaPublica.API.Entities;
using BibliotecaPublica.API.Helper.DB;

namespace BibliotecaPublica.API.Services
{
    public class BookService : IBookService
    {
        private readonly IDtoToEntity _dtoToEntity;
        private readonly IEntityToDto _entityToDto;
        private readonly DbContextSeed _dbContextSeed;

        public BookService(IDtoToEntity dtoToEntity, IEntityToDto entityToDto, DbContextSeed dbContextSeed)
        {
            _dtoToEntity = dtoToEntity;
            _dbContextSeed = dbContextSeed;
            _entityToDto = entityToDto;
        }

        public async Task<int> createBookAsync(BookDTO book)
        {
            BookEntity books = _dtoToEntity.bookDtoToEntity(book);

            //FIXME: Connection to DB here;

            _dbContextSeed.Books.Add(books);

            return await _dbContextSeed.SaveChangesAsync();
        }

        public async Task<BookDTO> GetBookAsync(int id)
        {
            BookEntity response = await _dbContextSeed.FindAsync<BookEntity>(id);
            if (response == null)
            {
                return new BookDTO();
            }

            BookDTO responseConverter = _entityToDto.bookEntityToDto(response);

            return responseConverter;
        }

        public IEnumerable<BookDTO> GetBooksAsync()
        {

            return (IEnumerable<BookDTO>) _dbContextSeed.Books.OrderBy(book => book.titulo);
        }
    }
}
