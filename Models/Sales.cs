using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Swagger.Models
{
    public class Sales
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement]
        [BsonRepresentation(BsonType.ObjectId)]
        public string user_id { get; set; }

        [BsonElement]
        public string date { get; set; }
        [BsonElement]
        public string Ref { get; set; }
        [BsonElement]

        public int is_pos { get; set; }

        [BsonElement]
        public string products { get; set; }
        [BsonElement]
        [BsonRepresentation(BsonType.ObjectId)]


        public string client_id { get; set; }
        [BsonElement]
        [BsonRepresentation(BsonType.ObjectId)]

        public string warehouse_id { get; set; }
        [BsonElement]

        public double tax_rate { get; set; }
        [BsonElement]

        public double TaxNet { get; set; }
        [BsonElement]

        public double discount { get; set; }
        [BsonElement]

        public double shipping { get; set; }
        [BsonElement]

        public double GrandTotal { get; set; }
        [BsonElement]

        public double paid_amount { get; set; }

        [BsonElement]

        public string payment_status { get; set; }

        [BsonElement]

        public string statut { get; set; }
        [BsonElement]

        public string notes { get; set; }
        [BsonElement]
        public string created_at { get; set; }
        [BsonElement]
        public string updated_at { get; set; }
        [BsonElement]
        public string deleted_at { get; set; }
    }
}