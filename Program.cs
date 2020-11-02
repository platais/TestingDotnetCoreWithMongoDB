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
            //var records = db.LoadRecords<PersonModel>("Users");

            //foreach (var rec in records)
            //{
            //    Console.WriteLine($"{ rec.ID }: {rec.FirstName} {rec.LastName}");
            //    if (rec.PrimaryAddress != null)
            //    {
            //        Console.WriteLine(rec.PrimaryAddress.City);
            //    }
            //    Console.WriteLine();
            //}

            var records = db.LoadRecords<NameModel>("Users");

            foreach (var rec in records)
            {
                Console.WriteLine($"{rec.FirstName} {rec.LastName}");
                Console.WriteLine();
            }


            //var oneRecord = db.LoadRecordById<PersonModel>("Users", new Guid("da39e7d4-ce97-48d6-a6e6-8b3d022046c6"));
            //oneRecord.DateOfBirth = new DateTime(1942, 11, 13, 0, 0, 0, DateTimeKind.Utc);
            //upserting
            //db.UpsertRecord("Users", oneRecord.Id, oneRecord);

            // db.DeleteRecord<PersonModel>("Users", oneRecord.Id);
            Console.ReadLine();
            //1:00:00
        }
    }
}
