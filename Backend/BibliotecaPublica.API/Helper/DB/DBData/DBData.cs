using BibliotecaPublica.API.Entities;

namespace BibliotecaPublica.API.Helper.DB.DBData
{
    public class DBData
    {
        private readonly DbContextSeed _dbContextSeed;

        public DBData(DbContextSeed dbContextSeed)
        {
            _dbContextSeed = dbContextSeed;
        }

        public async Task seedDBAsync()
        {
            await _dbContextSeed.Database.EnsureCreatedAsync();
            BookEntity book = new BookEntity
            {
                titulo = "Soy Leyenda",
                anio = DateTime.Now,
                genero = "Drama",
                numeroPaginas = 500
            };

           _dbContextSeed.Books.Add(book);
            await _dbContextSeed.SaveChangesAsync();
        }
    }
}
