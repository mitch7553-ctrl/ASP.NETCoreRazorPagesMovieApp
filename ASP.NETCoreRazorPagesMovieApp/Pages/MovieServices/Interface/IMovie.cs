namespace ASP.NETCoreRazorPagesMovieApp.Pages.MovieServices.Interface
{
    public interface IMovieInfo
    {
        int Id { get; set; }
        string Title { get; set; }
        string Genre { get; set; }
        decimal Rating { get; set; }  
        string Description { get; set; }
    }
}