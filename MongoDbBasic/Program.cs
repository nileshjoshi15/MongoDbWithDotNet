using MongoDbBasic.Data;
using MongoDbBasic.Domain;
using System;
using System.Threading.Tasks;

namespace MongoDbBasic
{
    class Program
    {
        private static PersonRepository personRepository = new PersonRepository();
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person
                {
                    FirstName = "Test12",
                    LastName = "Test Last2"
                };

                //MainAsync(p).Wait();
                //GetAndPrintPerson("5b023d5168b7fc1c9032ead1").Wait();
                GetAllPeople().Wait();
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Something went wrong {ex.GetBaseException()}");
            }
            
        }

        static async Task MainAsync(Person p)
        {
            await personRepository.SaveAsync(p);
        }
        static async Task GetAndPrintPerson(string id)
        {
            var personFromDatabase = await personRepository.GetByIdAsync(id);
            Console.WriteLine($"{personFromDatabase.FirstName}, {personFromDatabase.LastName}, id: {personFromDatabase.Id}");
        }

        static async Task GetAllPeople()
        {
            var people = await personRepository.FindAllAsyncNew();
            foreach (var pn in people)
            {
                Console.WriteLine($"{pn.FirstName}, {pn.LastName}, id: {pn.Id}");
            }
        }

    }
}


