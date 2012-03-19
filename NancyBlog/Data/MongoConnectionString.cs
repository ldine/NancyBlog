using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace NancyBlog.Data
{
    public static class MongoConnectionString
    {
        public static string Retrieve()
        {
            return ConfigurationManager.ConnectionStrings[Environment.MachineName].ConnectionString;
        }
    }
}