using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ASP.NETCoreRazorPagesMovieApp.Pages.MovieServices.Interface;
using ASP.NETCoreRazorPagesMovieApp.Pages.MovieServices.Models;


namespace ASP.NETCoreRazorPagesMovieApp.Pages.Movies
{
    public class IDetailsModel : PageModel
    {
        public MovieInfo? MovieInfo { get; set; }
        private readonly IService _service;
        public IDetailsModel(IService service)
        {
            _service = service;
        }
        public void OnGet(int? id)
        {
            MovieInfo = id.HasValue ? _service.GetMovieById(id.Value) : null;

        }
    }
}
