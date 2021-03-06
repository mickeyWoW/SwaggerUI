using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Swagger.Models
{
    public class RelationalSchema
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement]
        public string firstname { get; set; }

        [BsonElement]
        public string lastname { get; set; }
        [BsonElement]
        public string email { get; set; }
        [BsonElement]

        public string password { get; set; }
        [BsonElement]

        public string avatar { get; set; }
        [BsonElement]

        public int role_id { get; set; }
        [BsonElement]

        public int statut { get; set; }
        [BsonElement]
        public string created_at { get; set; }
        [BsonElement]
        public string updated_at { get; set; }
        [BsonElement]
        public string deleted_at { get; set; }
    }
}