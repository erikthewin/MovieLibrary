using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieLibraryDataAccess.DataAccess;
using MovieLibraryDataAccess.Models;

namespace MovieLibraryWeb.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly MovieContext _dbContext;

        public CreateModel(MovieContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public List<SelectListItem> DirectorOptions { get; set; }
        public List<SelectListItem> StudioOptions { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _dbContext.Movie.Add(Movie);
            await _dbContext.SaveChangesAsync();

            return RedirectToPage("/Movies");
        }
    }
}