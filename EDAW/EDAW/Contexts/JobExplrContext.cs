using EDAW.Data;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAW.Contexts
{
    class JobExplrContext
    {
        private IMongoDatabase explorerDB;
        
        public JobExplrContext(MongoClient client)
        {
            this.explorerDB = client.GetDatabase("EmployerData");
        }

        public IMongoCollection<BsonDocument> JobExplorers
        {
            get
            {
                return explorerDB.GetCollection<BsonDocument>("JobExplorers");
            }
        }
    }
}
