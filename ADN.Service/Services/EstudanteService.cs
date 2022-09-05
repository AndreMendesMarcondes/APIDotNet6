using ADN.Domain.Domain;
using ADN.Domain.DTO.Estudante;
using ADN.Domain.Interfaces.Repositorio;
using ADN.Domain.Interfaces.Services;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ADN.Service.Services
{
    public class EstudanteService : IEstudanteService
    {
        private readonly IEstudanteRepositorio _repositorio;
        private readonly IMapper _mapper;
        private readonly ILogger<EstudanteService> _log;

        public EstudanteService(IEstudanteRepositorio repositorio,
                                IMapper mapper,
                                ILogger<EstudanteService> log)
        {
            _repositorio = repositorio;
            _mapper = mapper;
            _log = log;
        }

        public async Task<List<Estudante>> GetAll()
        {
            _log.LogInformation("Buscando estudantes no service");
            return await _repositorio.GetAll();
        }

        public async Task Insert(EstudanteInsertDTO estudanteDTO)
        {
            try
            {
                _log.LogInformation($"Salvando estudante {JsonConvert.SerializeObject(estudanteDTO)} no banco de dados");
                Estudante estudante = _mapper.Map<Estudante>(estudanteDTO);

                _log.LogInformation($"Estudante mapeado com sucesso {JsonConvert.SerializeObject(estudante)}s");
                await _repositorio.Insert(estudante);
            }
            catch (Exception ex)
            {
                _log.LogError(ex, "Erro ao salvar estudante");
                throw;
            }   
        }
    }
}
