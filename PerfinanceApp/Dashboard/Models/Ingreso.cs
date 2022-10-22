using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Models
{
    public class Ingreso
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("valor")]
        public float Valor { get; set; }

        [BsonElement("categoria")]
        public string Categoria { get; set; }

        [BsonElement("usuarioId")]
        public string UsuarioId { get; set; }

    }
}
