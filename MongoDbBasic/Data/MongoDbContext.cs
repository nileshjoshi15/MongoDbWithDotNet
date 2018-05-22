using MongoDB.Driver;
using MongoDbBasic.Domain;
using System.Configuration;

namespace MongoDbBasic.Data
{
    public class MongoDbContext
    {
        private IMongoDatabase MongoDatabase { get; }
        public MongoDbContext()
            : this("MongoDb")
        {
        }

        public MongoDbContext(string connectionName)
        {
            var url = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;

            var mongoUrl = new MongoUrl(url);
            IMongoClient client = new MongoClient(mongoUrl);
            MongoDatabase = client.GetDatabase(mongoUrl.DatabaseName);
        }

       
        public IMongoCollection<Person> people => MongoDatabase.GetCollection<Person>("People");
    }
}
