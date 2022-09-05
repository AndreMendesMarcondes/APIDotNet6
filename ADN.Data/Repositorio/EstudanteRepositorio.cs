using ADN.Domain.Domain;
using ADN.Domain.DTO.Settings;
using ADN.Domain.Interfaces.Repositorio;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ADN.Data.Repositorio
{
    public class EstudanteRepositorio : IEstudanteRepositorio
    {
        private readonly IMongoCollection<Estudante> _collection;

        public EstudanteRepositorio(IOptions<MongoDBEstudanteSettings> mongoEstudanteSettings)
        {
            var mongoClient = new MongoClient(mongoEstudanteSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(mongoEstudanteSettings.Value.DatabaseName);
            _collection = mongoDatabase.GetCollection<Estudante>(mongoEstudanteSettings.Value.CollectionName);
        }

        public async Task<List<Estudante>> GetAll()
        {
            var result = await _collection.FindAsync(c => true);
            return result.ToList();
        }
    }
}
