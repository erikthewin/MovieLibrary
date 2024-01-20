using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieLibraryDataAccess.DataAccess;
using MovieLibraryDataAccess.Models;
using System.Text.Json;

namespace MovieLibraryWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MovieContext _db;

        public IndexModel(ILogger<IndexModel> logger, MovieContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            LoadSampleData();

            var movies = _db.Movie
                .Include(d => d.Director)
                .Include(s => s.Studio)
                .ToList();
        }

        private void LoadSampleData() {
            if (_db.Movie.Count() == 0)
            {
                string file = System.IO.File.ReadAllText("sample-movies.json");
                var movie = JsonSerializer.Deserialize<List<Movie>>(file);
                _db.AddRange(movie);
                _db.SaveChanges();
            }
        }
    }
}