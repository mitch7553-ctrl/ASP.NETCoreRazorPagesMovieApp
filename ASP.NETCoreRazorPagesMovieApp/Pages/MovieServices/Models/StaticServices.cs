using ASP.NETCoreRazorPagesMovieApp.Pages.MovieServices.Interface;

namespace ASP.NETCoreRazorPagesMovieApp.Pages.MovieServices.Models
{
    public class StaticServices : IService
    {
        // Static in-memory list of movies (seed data)
        private static readonly List<MovieInfo> Movies = new List<MovieInfo>
        {
            new MovieInfo { Id = 1, Title = "Inception", Year = 2010, Genre = "Sci-Fi", Rating = 8.8m, Description = "A mind-bending thriller." },
            new MovieInfo { Id = 2, Title = "The Matrix", Year = 1999, Genre = "Sci-Fi", Rating = 8.7m, Description = "Reality is not what it seems." },
            new MovieInfo { Id = 3, Title = "Interstellar", Year = 2014, Genre = "Sci-Fi", Rating = 8.6m, Description = "Space travel and family." },
            new MovieInfo { Id = 4, Title = "The Shawshank Redemption", Year = 1994, Genre = "Drama", Rating = 9.3m, Description = "Hope and friendship." },
            new MovieInfo { Id = 5, Title = "The Godfather", Year = 1972, Genre = "Crime", Rating = 9.2m, Description = "Family and power." },
            new MovieInfo { Id = 6, Title = "Pulp Fiction", Year = 1994, Genre = "Crime", Rating = 8.9m, Description = "Interwoven stories." },
            new MovieInfo { Id = 7, Title = "Fight Club", Year = 1999, Genre = "Drama", Rating = 8.8m, Description = "Identity and chaos." },
            new MovieInfo { Id = 8, Title = "Forrest Gump", Year = 1994, Genre = "Drama", Rating = 8.8m, Description = "Life as a journey." },
            new MovieInfo { Id = 9, Title = "The Dark Knight", Year = 2008, Genre = "Action", Rating = 9.0m, Description = "Heroism and chaos." },
            new MovieInfo { Id = 10, Title = "Gladiator", Year = 2000, Genre = "Action", Rating = 8.5m, Description = "Honor and revenge." }
        };

        public List<MovieInfo> GetMovies()
        {
            // Return a copy if you want to avoid callers modifying the list directly:
            return Movies.ToList();
        }

        public MovieInfo? GetMovieById(int id)
        {
            return Movies.FirstOrDefault(x => x.Id == id);
        }

        public void AppendMovie(MovieInfo movie)
        {
            // Ensure a unique Id
            var nextId = Movies.Any() ? Movies.Max(m => m.Id) + 1 : 1;
            movie.Id = nextId;
            Movies.Add(movie);
        }
    }
}