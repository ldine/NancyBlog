using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Simple.Data;
using Simple.Data.MongoDB;

namespace NancyBlog.Data
{
    public class MongoDatabaseProvider : IDatabaseProvider
    {

        public dynamic GetDb()
        {
            var connectionString = MongoConnectionString.Retrieve();
            return Database.Opener.OpenMongo(connectionString);
        }
    }

    public interface IDatabaseProvider
    {
        dynamic GetDb();
    }
}