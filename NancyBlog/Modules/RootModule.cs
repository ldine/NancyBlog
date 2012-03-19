using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using NancyBlog.Services;
using NancyBlog.Models;

namespace NancyBlog.Modules
{
    public class RootModule : NancyModule
    {
        public RootModule(IUsersService usersService)
        {
            Get["/"] = parameters => "Hello World!";
        }
    }
}