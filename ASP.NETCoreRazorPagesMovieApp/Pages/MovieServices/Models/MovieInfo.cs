using ASP.NETCoreRazorPagesMovieApp.Pages.MovieServices.Interface;
using System.ComponentModel.DataAnnotations;
namespace ASP.NETCoreRazorPagesMovieApp.Pages.MovieServices.Models
{
    public class MovieInfo : IMovieInfo
    {
       
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Required")]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, ErrorMessage ="Genre can't exceed no more than 100 characters.")]
        public string Genre { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(0.0, 10.0, ErrorMessage = "Ratings are only from 0 to 5.")]
        public decimal Rating { get; set; }   // e.g. 8.7

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Required")]
        public int Year { get; set; }

        [DataType(DataType.Text)]
        public string Description { get; set; } = string.Empty;
    }
}