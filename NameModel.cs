using MongoDB.Bson.Serialization.Attributes;
using System;

namespace TestingDotnetCoreWithMongoDB
{
    public class NameModel 
    {
        [BsonId] // in db it will be _id
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
