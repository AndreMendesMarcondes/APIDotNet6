using ADN.Domain.Domain;

namespace ADN.Domain.Interfaces.Repositorio
{
    public interface IEstudanteRepositorio
    {
        Task<List<Estudante>> GetAll();
        Task<List<Estudante>> GetById(string id);
        Task Update(Estudante estudante);
        Task Delete(string id);
        Task Insert(Estudante estudante);
    }
}
