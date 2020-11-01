using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;

namespace TestingDotnetCoreWithMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("DemoMongoDB");
            db.InsertRecord("Users", new PersonModel { FirstName = "HumansName", LastName = "HumansSurname" });
            Console.ReadLine();
        }
    }

    public class PersonModel 
    {
        [BsonId] // in db it will be _id
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class MongoCRUD 
    {
        //ctrl + .
        private IMongoDatabase db;
        //these two line in a constractor create a connecion and open connection
        //it allows creat connection once and use it trough rest of your app or
        //open it , do your work and close it
        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void InsertRecord<T>(string table, T record) 
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }
    }
}
