using System;

namespace TestingDotnetCoreWithMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("DemoMongoDB");

            //PersonModel person = new PersonModel
            //{
            //    FirstName = "Rob",
            //    LastName = "RobsLastname",
            //    PrimaryAddress = new AddressModel
            //    {
            //        Address = "Somaddress 99-95",
            //        City = "RIX",
            //        ZipCode = "LV102030"
            //    }
            //};

            //db.InsertRecord("Users", person);//{ FirstName = "HumansName", LastName = "HumansSurname" });

            // from users table
            var records = db.LoadRecords<PersonModel>("Users");

            foreach (var rec in records)
            {
                Console.WriteLine($"{ rec.ID }: {rec.FirstName} {rec.LastName}");
            }

            Console.ReadLine();
        }
    }
}
