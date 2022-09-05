using ADN.Domain.Domain;
using ADN.Domain.Interfaces.Repositorio;
using ADN.Domain.Interfaces.Services;

namespace ADN.Service.Services
{
    public class EstudanteService : IEstudanteService
    {
        private readonly IEstudanteRepositorio _repositorio;

        public EstudanteService(IEstudanteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<Estudante>> GetAll()
        {
            return await _repositorio.GetAll();
        }
    }
}
