using MongoDB.Driver;
using MongoDbBasic.Domain;

namespace MongoDbBasic.Data
{
    public class PersonRepository : BaseMongoRepository<Person>
    {
        private const string PeopleCollectionName = "People";

        private readonly MongoDbContext _mctx;

        public PersonRepository()
        {
            _mctx = new MongoDbContext(); ;
        }

        protected override IMongoCollection<Person> Collection
        {
            get
            {
                return _mctx.MongoDatabase.GetCollection<Person>(PeopleCollectionName);
            }
        }
    }
}
