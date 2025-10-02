using ASP.NETCoreRazorPagesMovieApp.Pages.MovieServices.Interface;
namespace ASP.NETCoreRazorPagesMovieApp.Pages.MovieServices.Models
{
    public class MovieInfo : IMovieInfo
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public decimal Rating { get; set; }    // e.g. 8.7
        public int Year { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}