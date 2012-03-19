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
        public RootModule(IPostsService postsService, IUsersService usersService)
        {
            Get["/"] = parameters => "Hello World!";
            Get["/testpost"] = parameters => postsService.AuthorPost("Hello World", "Testing posting!", usersService.GetByUsername("LDine")).ToString();
        }
    }
}