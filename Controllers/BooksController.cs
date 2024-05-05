using AutoMapper;
using LibraryAPI.Data;
using LibraryAPI.Dtos.BookDto;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController: ControllerBase
{
    private LibraryAPIContext _context;
    private IMapper _mapper;

    
    public BooksController(LibraryAPIContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    #region Get Books
    [HttpGet]
    public IActionResult  GetBooks([FromQuery] int skip = 0 , [FromQuery] int take = 50)
    {
        try
        {
            var books = _context.Books
                .ToList() 
                .Skip(skip)
                .Take(take)
                .ToList(); 
            
            return Ok(books);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    #endregion

    #region Set Books

    [HttpPost]
    public IActionResult SetBook([FromBody] CreateBookDto bookDto)
    {
        Books book = _mapper.Map<Books>(bookDto);
        _context.Books.Add(book);
        _context.SaveChanges();
        return Ok(book);
    }
    

    #endregion
    
}