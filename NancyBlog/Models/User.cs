using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace NancyBlog.Models
{
    public class User
    {
        public virtual ObjectId Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual DateTime Joined { get; set; }
    }
}