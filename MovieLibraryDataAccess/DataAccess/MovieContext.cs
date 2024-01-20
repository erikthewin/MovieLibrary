using Microsoft.EntityFrameworkCore;
using MovieLibraryDataAccess.Models;

namespace MovieLibraryDataAccess.DataAccess
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Studio> Studio { get; set; }
        public DbSet<Director> Director { get; set; }
    }
}