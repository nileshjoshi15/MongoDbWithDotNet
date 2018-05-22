using MongoDB.Driver;
using MongoDbBasic.Domain;
using System;
using System.Threading.Tasks;

namespace MongoDbBasic.Data
{
    public class PersonRepository : BaseMongoRepository<Person>
    {
        
        private readonly MongoDbContext _mctx;

        public PersonRepository()
        {
            _mctx = new MongoDbContext();
        }

        protected override IMongoCollection<Person> Collection
        {
            get
            {
                return _mctx.people;

            }
        }




    }
}
