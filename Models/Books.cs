using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models;

public class Books
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    public string Author { get; set; }
    [Required]
    public int Year { get; set; }
    
}