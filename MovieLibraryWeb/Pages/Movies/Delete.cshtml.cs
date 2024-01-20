using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieLibraryDataAccess.DataAccess;
using MovieLibraryDataAccess.Models;

namespace MovieLibraryWeb.Pages.Movies
{
    public class DeleteModel : PageModel
    {
        private readonly MovieContext _context;

        public DeleteModel(MovieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie
                .Include(m => m.Director)
                .Include(m => m.Studio)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Movie == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Movie == null)
            {
                return NotFound();
            }

            _context.Movie.Remove(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Movies/Index");
        }
    }
}
