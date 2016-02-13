using EDAW.Interfaces;
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace EDAW.Database
{
    public class Mongo : IRepository
    {
        private IMongoClient _client;
        private IMongoDatabase _db
        {
            get
            {
                return this._client.GetDatabase("EmployerData");
            }
        }

        public Mongo()
        {
            MongoClientSettings settings = new MongoClientSettings();
            settings.Server = new MongoServerAddress("localhost", 27017);

            _client = new MongoClient(settings);         
        }

        public void Add<T>(IEnumerable<T> items) where T : class, new()
        {
            _db.GetCollection<T>(typeof(T).Name).InsertMany(items);
        }

        public void Add<T>(T item) where T : class, new()
        {
            _db.GetCollection<T>(typeof(T).Name).InsertOne(item);
        }
       
        public IQueryable<T> All<T>() where T : class, new()
        {
            return _db.GetCollection<T>(typeof(T).Name).AsQueryable();
        }

        public void Delete<T>(Expression<Func<T, bool>> predicate) where T : class, new()
        {
            _db.GetCollection<T>(typeof(T).Name).DeleteMany<T>(predicate);
        }

        public void DeleteAll<T>() where T : class, new()
        {
            _db.DropCollection(typeof(T).Name);
        }

        public T Single<T>(Expression<Func<T, bool>> predicate) where T : class, new()
        {
            return All<T>().Where(predicate).SingleOrDefault<T>();
        }
    }
}
