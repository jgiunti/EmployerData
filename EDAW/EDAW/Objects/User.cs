using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EDAW.Data
{
    public class User
    {


        public ObjectId id { get; set; }
        [BsonIgnoreIfNull]
        
        public string username { get; set; }
        public string password { get; set; }
        public double security_level { get; set; }
       

        public User(string use, string pass, double sec)
        {
            username = use;
            password = pass;
            security_level = sec;
            
        }
        public User() { }
    }
}
