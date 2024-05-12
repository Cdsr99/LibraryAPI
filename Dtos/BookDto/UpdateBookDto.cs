using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Dtos.BookDto;

public class UpdateBookDto
{
    [Required(ErrorMessage = "The name of the book is required")]
    [MinLength(5, ErrorMessage = "The name of the book must have at least 5 characters")]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    public string Author { get; set; }
    [Required]
    public int Year { get; set; }
}