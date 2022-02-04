using Microsoft.EntityFrameworkCore;
using BibliotecaPublica.API.Entities;

namespace BibliotecaPublica.API.Helper.DB
{
    public class DbContextSeed : DbContext
    {
        public DbContextSeed(DbContextOptions<DbContextSeed> options) : base(options)
        {
        }
        public DbSet<BookEntity> Books { get; set; }

        public DbSet<AuthorEntity> Author { get; set; }
    }
}
