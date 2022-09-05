using ADN.Domain.Domain;
using ADN.Domain.DTO.Estudante;
using ADN.Domain.Interfaces.Repositorio;
using ADN.Domain.Interfaces.Services;
using AutoMapper;

namespace ADN.Service.Services
{
    public class EstudanteService : IEstudanteService
    {
        private readonly IEstudanteRepositorio _repositorio;
        private readonly IMapper _mapper;

        public EstudanteService(IEstudanteRepositorio repositorio,
                                IMapper mapper)
        {
            _repositorio = repositorio;
            _mapper = mapper;
        }

        public async Task<List<Estudante>> GetAll()
        {
            return await _repositorio.GetAll();
        }

        public async Task Insert(EstudanteInsertDTO estudanteDTO)
        {
            Estudante estudante = _mapper.Map<Estudante>(estudanteDTO);
            await _repositorio.Insert(estudante);
        }
    }
}
