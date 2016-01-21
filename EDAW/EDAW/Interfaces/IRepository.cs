using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAW.Interfaces
{
    interface IRepository
    {
        void Delete<T>(Func<T, bool> predicate) where T : class, new();

        void Delete<T>(T item) where T : class, new();

        void DeleteAll<T>() where T : class, new();

        T Single<T>(Func<T, bool> predicate) where T : class, new();

        IQueryable<T> All<T>() where T : class, new();

        IQueryable<T> All<T>(int page, int pageSize) where T : class, new();

        void Add<T>(T item) where T : class, new();

        void Add<T>(IEnumerable<T> items) where T : class, new();
    }
}
