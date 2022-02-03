using Microsoft.AspNetCore.Mvc;
using BibliotecaPublica.API.DTO;
using BibliotecaPublica.API.Services;

namespace BibliotecaPublica.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {

        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost("{book}")] 
        public async Task<BookDTO> postNewBook([FromBody] BookDTO bookDto)
        {
            if (bookDto == null)
            {
               return new BookDTO();
            }

            BookDTO response = _bookService.createBookAsync(bookDto);

            return response;

        }

    }
}
