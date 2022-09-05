using ADN.Domain.Domain;
using ADN.Domain.DTO.Estudante;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADN.Domain.Mapper
{
    public class EstudanteMapperProfile : Profile
    {
        public EstudanteMapperProfile()
        {
            CreateMap<Estudante, EstudanteInsertDTO>().ReverseMap();
        }
    }
}
