using EDAW.Data;
using EDAW.Database;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;


namespace EDAW.Contexts
{
    public static class UserManager
    {
        public static IQueryable<User> Users
        {
            get
            {
                return DBContext.Current.All<User>();
            }
        }
        public static IEnumerable<User> Find(Func<User, bool> predicate)
        {
            return Users.AsQueryable().Where(predicate);
        }

        public static void Add(User user)
        {
            DBContext.Current.Add<User>(user);
        }

        public static void Delete(User user)
        {
            DBContext.Current.Delete<User>(x => x.id == user.id);
        }

        public static void Update(User user, UpdateDefinition<User> update)
        {
            DBContext.Current.Update<User>(x => x.id == user.id, update);
        }
    }
}
