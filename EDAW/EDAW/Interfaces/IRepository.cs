﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EDAW.Interfaces
{
    public interface IRepository
    {
        void Delete<T>(Expression<Func<T, bool>> expression) where T : class, new();

        void DeleteAll<T>() where T : class, new();

        T Single<T>(Expression<Func<T, bool>> expression) where T : class, new();

        IQueryable<T> All<T>() where T : class, new();

        void Add<T>(T item) where T : class, new();

        void Add<T>(IEnumerable<T> items) where T : class, new();
    }
}
