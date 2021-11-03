using BlogAPI.Shared.Entities;
using System;

namespace BlogAPI.Domain.Entities
{
    public class ArticleComment : Entity
    {
        public ArticleComment(string commentText, User user)
        {
            CommentText = commentText;
            CreatedAt = DateTime.Now;
            User = user;
            UserId = user.Id;
        }

        public string CommentText { get; set; }
        public DateTime CreatedAt { get; private set; }

        public int ArticleId { get; private set; }
        public Article Article { get; private set; }

        public int UserId { get; private set; }
        public User User { get; private set; }

        public void Update(string commentText)
        {
            CommentText = commentText;
        }
    }
}
