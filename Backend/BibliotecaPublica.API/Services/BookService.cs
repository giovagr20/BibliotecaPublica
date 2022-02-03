using BibliotecaPublica.API.DTO;
using BibliotecaPublica.API.Helper;
using BibliotecaPublica.API.Entities;

namespace BibliotecaPublica.API.Services
{
    public class BookService : IBookService
    {
        private readonly IDtoToEntity _dtoToEntity;

        public BookService(IDtoToEntity dtoToEntity)
        {
            _dtoToEntity = dtoToEntity;
        }

        public async BookDTO createBookAsync(BookDTO book)
        {
            BookEntity books = _dtoToEntity.bookDtoToEntity(book);

            //FIXME: Connection to DB here;

            return new BookDTO();
        }
    }
}
