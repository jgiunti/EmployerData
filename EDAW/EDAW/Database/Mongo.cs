using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAW.Database
{
    public class Mongo
    {
        public MongoClient client;

        public Mongo()
        {
            MongoClientSettings settings = new MongoClientSettings();
            settings.Server = new MongoServerAddress("localhost", 27017);

            this.client = new MongoClient(settings);
        }      
    }
}
