using EDAW.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAW.Database
{
    public static class DBContext
    {
        private static IRepository _current;

        public static IRepository Current
        {
            get
            {
                return GetOrCreateDBSession();
            }
        }

        private static IRepository GetOrCreateDBSession()
        {
            if (_current == null)
            {
                return new Mongo() as IRepository;
            }
            else
            {
                return _current;
            }
        }
    }
}
