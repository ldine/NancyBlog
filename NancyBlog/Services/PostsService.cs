using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NancyBlog.Data;
using NancyBlog.Models;
using MongoDB.Bson;

namespace NancyBlog.Services
{
    public class PostsService : BaseService, IPostsService
    {
        public PostsService(IDatabaseProvider databaseProvider) : base(databaseProvider) { }

        public Post Get(string id)
        {
            return _db.Posts.FetchById(id);
        }

        public Post Get(ObjectId id)
        {
            return _db.Posts.FetchById(id);
        }

        public bool Create(Post post)
        {
            _db.Posts.Insert(post);
            return true;
        }

        public bool AuthorPost(string title, string body, User author)
        {
            _db.Posts.Insert(new Post { Title = title, Body = body, Author = author.Username, AuthorId = author.Id });
            return true;
        }

        public IList<Post> PostsForAuthor(User author)
        {
            return _db.Posts.FindAllByAuthorId(author.Id).ToList<Post>();
        }

        public IList<Post> All()
        {
            return _db.Posts.All().ToList<Post>();
        }
    }

    public interface IPostsService
    {
        Post Get(string id);
        Post Get(ObjectId id);
        bool Create(Post post);
        bool AuthorPost(string title, string body, User author);
        IList<Post> PostsForAuthor(User author);
        IList<Post> All();
    }
}