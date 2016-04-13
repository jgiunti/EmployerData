using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EDAW.Data
{
    public class User
    {
        public ObjectId id;
        [BsonIgnoreIfNull]
        
        public string username { get; set; }
        public string password { get; set; }
        public enum SecurityLevel
        {
            user,
            admin
        };
        public SecurityLevel securityLevel { get; set; }
        public string savePath { get; set; }

        public User(string use, string pass, SecurityLevel sec, string path)
        {
            
            username = use;
            password = pass;
            securityLevel = sec;
            savePath = path;
            
        }
        public User() { }
    }
}
