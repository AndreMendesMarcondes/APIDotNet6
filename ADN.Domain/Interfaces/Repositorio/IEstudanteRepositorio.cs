using ADN.Domain.Domain;

namespace ADN.Domain.Interfaces.Repositorio
{
    public interface IEstudanteRepositorio
    {
        Task<List<Estudante>> GetAll();
        Task Insert(Estudante estudante);
    }
}
