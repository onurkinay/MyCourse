using MongoDB.Bson.Serialization.Attributes;

namespace MyCourse.Catalog.API.Repositories;

public class BaseEntity
{
    [BsonElement("_id")]
    public  Guid Id { get; set; }
}