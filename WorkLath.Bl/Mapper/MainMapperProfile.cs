using AutoMapper;
using WorkLath.Bl.Dto;
using WorkLath.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkLath.Bl.Mapper
{
    public class MainMapperProfile : Profile
    {
        public MainMapperProfile()
        {
            CreateMap<Document, DocumentDto>();
            CreateMap<DocumentDto, Document>();

        }
    }
}
