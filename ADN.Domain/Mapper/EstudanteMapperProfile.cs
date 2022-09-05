using ADN.Domain.Domain;
using ADN.Domain.DTO.Estudante;
using AutoMapper;

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
