using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ADN.Domain.Domain
{
    public class Estudante
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        private string Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
