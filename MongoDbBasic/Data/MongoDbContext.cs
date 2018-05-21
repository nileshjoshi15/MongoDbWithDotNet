using MongoDB.Driver;
using System.Configuration;

namespace MongoDbBasic.Data
{
    public class MongoDbContext
    {
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

        public IMongoDatabase MongoDatabase { get; }
    }
}
