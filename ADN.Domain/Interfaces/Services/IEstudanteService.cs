using ADN.Domain.Domain;

namespace ADN.Domain.Interfaces.Services
{
    public interface IEstudanteService
    {
        Task<List<Estudante>> GetAll();
    }
}
