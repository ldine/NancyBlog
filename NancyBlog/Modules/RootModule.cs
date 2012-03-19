using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace NancyBlog.Modules
{
    public class RootModule : NancyModule
    {
        public RootModule()
        {
            Get["/"] = parameters => "Hello World!";
        }
    }
}