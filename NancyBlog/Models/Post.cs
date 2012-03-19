using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace NancyBlog.Models
{
    public class Post
    {
        public virtual ObjectId Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Body { get; set; }
        public virtual ObjectId AuthorId { get; set; }
        public virtual string Author { get; set; }
    }
}