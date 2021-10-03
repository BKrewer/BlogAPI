using BlogAPI.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogAPI.Domain.Entities
{
    public class Article : Entity
    {
        private readonly IList<ArticleComment> _comments;

        public Article(string title, string subtitle, string body)
        {
            Title = title;
            Subtitle = subtitle;
            Body = body;
            CreatedAt = DateTime.Now;
            Visible = true;
            _comments = new List<ArticleComment>();
        }

        public string Title { get; private set; }
        public string Subtitle { get; private set; }
        public string Body { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Visible { get; private set; }
        public IReadOnlyCollection<ArticleComment> Comments { get { return _comments.ToArray(); } }

        public int CategoryId { get; private set; }
        public Category Category { get; private set; }
    }
}
