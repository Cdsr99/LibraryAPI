using System.Runtime.InteropServices.JavaScript;
using AutoMapper;
using LibraryAPI.Data;
using LibraryAPI.Dtos.BookDto;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

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
    public IEnumerable<Books> GetBooks([FromQuery] int skip = 0 , [FromQuery] int take = 50)
    {
            return _context.Books
                .Skip(skip)
                .Take(take);
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
    
    #region Getting book by Id
    [HttpGet("{id}")]
    public IActionResult SearchBook(int id)
    {
        var result = _context.Books.FirstOrDefault(a => a.Id == id);
        
        if (result == null)
        {
            return NotFound();
        }
        
        return Ok(result);
    }
    #endregion
    
    #region Updating book
    [HttpPut("{id}")]
    public IActionResult UpdateBooks(int id, [FromBody] UpdateBookDto bookDto)
    {
        var result = _context.Books.FirstOrDefault(a => a.Id == id);
        
        if (result == null)
        {
            return NotFound();
        }

        _mapper.Map(bookDto, result);
        _context.SaveChanges();
        return Ok(result);
    }
    #endregion
    
    #region Deleting book
    [HttpDelete("{id}")]
    public IActionResult DeleteBooks(int id)
    {
        var book = _context.Books.FirstOrDefault(a => a.Id == id);

        if (book == null) return NotFound();
        _context.Remove(book);
        _context.SaveChanges();
        return NoContent();
    }
    #endregion
    
}