using BlogAPI.Shared.Entities;
using System;

namespace BlogAPI.Domain.Entities
{
    public class Articles : Entity
    {
        public Articles(string title, string subtitle, string body)
        {
            Title = title;
            Subtitle = subtitle;
            Body = body;
            CreatedAt = DateTime.Now;
            Visible = true;
        }

        public string Title { get; private set; }
        public string Subtitle { get; private set; }
        public string Body { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Visible { get; private set; }
    }
}
