using ASP.NETCoreRazorPagesMovieApp.Pages.MovieServices.Interface;
using ASP.NETCoreRazorPagesMovieApp.Pages.MovieServices.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NETCoreRazorPagesMovieApp.Pages.Movies
{
    public class inputmoviedataModel : PageModel
    {

        public MovieInfo? MovieInfo { get; set; }
        private readonly IService _service;
        public inputmoviedataModel(IService service)
        {
            _service = service;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(MovieInfo movieinfo)
        {
            movieinfo.Id = _service.GetMovies().Count + 1;
            _service.AppendMovie(movieinfo);
            return RedirectToPage("Index");
        }
        
    }
}
