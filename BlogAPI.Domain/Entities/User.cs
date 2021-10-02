using BlogAPI.Domain.ValueObjects;
using BlogAPI.Shared.Entities;
using System;

namespace BlogAPI.Domain.Entities
{
    public class User : Entity
    {
        public User(Name name, DateTime birthDate, Email email, string password)
        {
            Name = name;
            BirthDate = birthDate;
            Email = email;
            Password = password;
            Active = true;
        }

        public Name Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; private set; }
        public bool Active { get; private set; }
    }
}
