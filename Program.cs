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
}
