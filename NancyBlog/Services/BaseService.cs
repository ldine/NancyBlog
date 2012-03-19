using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NancyBlog.Data;

namespace NancyBlog.Services
{
    public abstract class BaseService
    {
        internal dynamic _db;

        public BaseService(IDatabaseProvider databaseProvider)
        {
            _db = databaseProvider.GetDb();
        }
    }
}