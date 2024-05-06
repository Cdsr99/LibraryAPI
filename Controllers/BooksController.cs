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
    
}