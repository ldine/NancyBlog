﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NancyBlog.Models;
using MongoDB.Bson;
using NancyBlog.Data;

namespace NancyBlog.Services
{
    public class UsersService : BaseService, IUsersService
    {
        public UsersService(IDatabaseProvider databaseProvider) : base(databaseProvider) { }

        public User Get(ObjectId id)
        {
            return (User)_db.FindById(id);
        }

        public User Get(string id)
        {
            return (User)_db.FindById(id);
        }

        public bool Create(User user)
        {
            _db.Users.Insert(user);
            return true;
        }
    }

    public interface IUsersService
    {
        User Get(ObjectId id);
        User Get(string id);
        bool Create(User user);
    }
}