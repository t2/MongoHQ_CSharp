using MongoDB.Bson;

namespace MongoHQ_CSharp.Models.DTO
{
    public class Developer
    {
        public BsonObjectId id { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public BsonArray languages { get; set; }
    }
}