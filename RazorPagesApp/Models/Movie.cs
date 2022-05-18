using System.ComponentModel.DataAnnotations;

namespace RazorPagesApp.Pages;

public class Movie
{
    public int MovieID { get; set; }
    public string Title { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime ReleaseDate { get; set; }
    public string Genre { get; set; }
    public decimal Price { get; set; }
}