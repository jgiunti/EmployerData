using EDAW.Interfaces;
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public void Add<T>(T item) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> All<T>() where T : class, new()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> All<T>(int page, int pageSize) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T item) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(Func<T, bool> predicate) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public void DeleteAll<T>() where T : class, new()
        {
            throw new NotImplementedException();
        }

        public T Single<T>(Func<T, bool> predicate) where T : class, new()
        {
            throw new NotImplementedException();
        }
    }
}
