using BibliotecaPublica.API.DTO;
using BibliotecaPublica.API.Entities;
using BibliotecaPublica.API.Helper;
using BibliotecaPublica.API.Helper.DB;

namespace BibliotecaPublica.API.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IDtoToEntity _dtoToEntity;
        private readonly IEntityToDto _entityToDto;
        private readonly DbContextSeed _dbContextSeed;

        public AuthorService(IDtoToEntity dtoToEntity, IEntityToDto entityToDto, DbContextSeed dbContextSeed)
        {
            _dbContextSeed = dbContextSeed;
            _dtoToEntity = dtoToEntity;
            _entityToDto = entityToDto;
        }
        public async Task<int> createAuthorAsync(AuthorDTO author)
        {
            AuthorEntity authorEntity = _dtoToEntity.authorDtoToEntity(author);

            _dbContextSeed.Author.Add(authorEntity);

            return await _dbContextSeed.SaveChangesAsync();
        }

        public Task<IAsyncEnumerable<AuthorDTO>> getAllAuthorAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<AuthorDTO> getAuthorById(int id)
        {
            AuthorEntity author = await _dbContextSeed.Author.FindAsync(id);

            if (author == null)
            {
                return new AuthorDTO();
            }

            AuthorDTO authorDTO = _entityToDto.authorEntityToDto(author);

            return authorDTO;
        }
    }
}
