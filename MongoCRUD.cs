using MongoDB.Driver;

namespace TestingDotnetCoreWithMongoDB
{
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
