using BibliotecaPublica.API.DTO;
using BibliotecaPublica.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaPublica.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
           _authorService = authorService;
        }

        [HttpGet]
        public async Task<IActionResult> getAuthorById([FromRoute] int id)
        {
            return Ok(await _authorService.getAuthorById(id));
        }

        [HttpPost]
        public async Task<IActionResult> postAuthorById([FromBody] AuthorDTO authorDTO)
        {
            if (authorDTO == null)
            {
                return BadRequest();
            }

            return Ok(await _authorService.createAuthorAsync(authorDTO));
        }
    }
}
