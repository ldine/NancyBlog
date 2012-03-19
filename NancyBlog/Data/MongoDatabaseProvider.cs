using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Simple.Data;

namespace NancyBlog.Data
{
    public class MongoDatabaseProvider : IDatabaseProvider
    {

        public dynamic GetDb()
        {
            var connectionString = MongoConnectionString.Retrieve();
            return Database.OpenConnection(connectionString);
        }
    }

    public interface IDatabaseProvider
    {
        dynamic GetDb();
    }
}