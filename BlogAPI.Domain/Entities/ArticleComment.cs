﻿using BlogAPI.Shared.Entities;
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
    }
}