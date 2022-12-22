using AutoMapper;
using P228FirstAPI.DTOs.CategoryDTOs;
using P228FirstAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228FirstAPI.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryForListDto>();

            CreateMap<Category, CategoryForDetailDto>()
                .ForMember(des => des.CategoryKey, src => src.MapFrom(c => c.Id))
                .ForMember(des => des.Ad, src => src.MapFrom(c => c.Name))
                .ForMember(des => des.KimYarad, src => src.MapFrom(c => c.CreatedBy))
                .ForMember(des => des.ImagePath, src => src.MapFrom(c => "/asdasd/asd/asd/"));

            CreateMap<CategoryForCreateDto, Category>()
                .ForMember(des => des.CreatedAt, src => src.MapFrom(c => DateTime.UtcNow.AddHours(4)))
                .ForMember(des => des.CreatedBy, src => src.MapFrom(c => "System"));
        }
    }
}
