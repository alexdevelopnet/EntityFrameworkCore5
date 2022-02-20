using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class DbContextCore5 : DbContext
    {
        public DbContextCore5(DbContextOptions options) : base(options) { }

        public DbSet<Filme> Filmes { get; set; }
    }
}