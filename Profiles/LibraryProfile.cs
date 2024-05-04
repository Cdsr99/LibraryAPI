using AutoMapper;
using LibraryAPI.Dtos.BookDto;
using LibraryAPI.Models;

namespace LibraryAPI.Profiles;

public class LibraryProfile: Profile
{
    public LibraryProfile() 
    {
        CreateMap<CreateBookDto, Books>();
        //CreateMap<UpdateFilmeDto, Filme>();
        //CreateMap<Filme, UpdateFilmeDto>();
    }
}