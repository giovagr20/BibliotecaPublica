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

        [HttpPost] 
        public async Task<IActionResult> postNewBook([FromBody] BookDTO bookDto)
        {
            if (bookDto == null)
            {
                return BadRequest();
            }

            return Ok(await _bookService.createBookAsync(bookDto));

        }

        [HttpGet]
        public async Task<IActionResult> getBook([FromRoute] int id) {
            
            return Ok(await _bookService.GetBookAsync(id)); 
        }
    }
}
