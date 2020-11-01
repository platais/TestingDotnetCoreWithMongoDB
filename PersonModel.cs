using MongoDB.Bson.Serialization.Attributes;
using System;

namespace TestingDotnetCoreWithMongoDB
{
    public class PersonModel 
    {
        [BsonId] // in db it will be _id
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel PrimaryAddress { get; set; }

    }
}
