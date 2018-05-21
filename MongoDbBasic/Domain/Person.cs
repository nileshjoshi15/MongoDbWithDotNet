using MongoDbBasic.Interface;

namespace MongoDbBasic.Domain
{
    public class Person : IEntity
    {
        public string Id { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}
