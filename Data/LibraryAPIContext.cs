using LibraryAPI.Models;

namespace LibraryAPI.Data;
using Microsoft.EntityFrameworkCore;
public class LibraryAPIContext: DbContext
{
    public LibraryAPIContext(DbContextOptions<LibraryAPIContext> option): base (option)
    {
            
    }
    
    public DbSet<Books> Books { get; set; }
}