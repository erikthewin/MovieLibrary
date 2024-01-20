using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieLibraryDataAccess.DataAccess;
using MovieLibraryDataAccess.Models;

namespace MovieLibraryWeb.Pages
{
    public class MoviesModel : PageModel
    {
        private readonly MovieContext _context;

        public MoviesModel(MovieContext context)
        {
            _context = context;
        }

        public List<Movie> Movies { get; set; }

        public void OnGet()
        {
            Movies = _context.Movie
                .Include(d => d.Director)
                .Include(s => s.Studio)
                .ToList();
        }
    }
}
