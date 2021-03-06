using BlogAPI.Domain.ValueObjects;
using BlogAPI.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogAPI.Domain.Entities
{
    public class User : Entity
    {
        private readonly IList<Article> _articles; 

        public User(Name name, DateTime birthDate, Email email, string password)
        {
            Name = name;
            BirthDate = birthDate;
            Email = email;
            Password = password;
            Active = true;
            _articles = new List<Article>();

            AddNotifications(name, email);
        }

        public Name Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; private set; }
        public bool Active { get; private set; }
        public IReadOnlyCollection<Article> Articles { get { return _articles.ToArray(); } }

        public void Update(Name name, DateTime birthDate, Email email)
        {
            Name = name;
            BirthDate = birthDate;
            Email = email;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }

        public void ChangeActive()
        {
            Active = !Active;
        }
    }
}
