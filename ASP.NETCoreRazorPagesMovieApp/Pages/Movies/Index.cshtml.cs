using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Razor.TagHelpers;
using ASP.NETCoreRazorPagesMovieApp.Pages.MovieServices.Interface;
using ASP.NETCoreRazorPagesMovieApp.Pages.MovieServices.Models;



namespace ASP.NETCoreRazorPagesMovieApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly IService _service;
        public IndexModel(IService service)
        {
            _service = service; 
        }
        public List<MovieInfo>? Movies { get; set; }
        
        public void OnGet()
        {
            Movies = _service.GetMovies();
        }
    }
}
