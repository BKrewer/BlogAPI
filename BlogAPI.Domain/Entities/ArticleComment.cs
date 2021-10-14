using BlogAPI.Shared.Entities;
using System;

namespace BlogAPI.Domain.Entities
{
    public class ArticleComment : Entity
    {
        public ArticleComment(string commentText)
        {
            CommentText = commentText;
            CreatedAt = DateTime.Now;
        }

        public string CommentText { get; set; }
        public DateTime CreatedAt { get; private set; }

        public int ArticleId { get; private set; }
        public Article Article { get; private set; }

        public void Update(string commentText)
        {
            CommentText = commentText;
        }
    }
}
