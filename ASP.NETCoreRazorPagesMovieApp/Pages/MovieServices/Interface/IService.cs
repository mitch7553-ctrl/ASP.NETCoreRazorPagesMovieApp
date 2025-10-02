using ASP.NETCoreRazorPagesMovieApp.Pages.MovieServices.Models;

using System.Collections.Generic;


namespace ASP.NETCoreRazorPagesMovieApp.Pages.MovieServices.Interface
{
    public interface IService
    {
        List<MovieInfo> GetMovies();
        MovieInfo? GetMovieById(int id);
        void AppendMovie(MovieInfo movie);
    }
}