﻿using BlogApp.Data.Abstract;
using BlogApp.Data.Db;
using BlogApp.Entity;

namespace BlogApp.Data.Concrete
{
    public class CommentRepository:ICommentRepository
    {
        private BlogContext _context;
        public CommentRepository(BlogContext context)
        {
            _context = context;
        }
        public IQueryable<Comment> Comments => _context.Comments;

        public void CreateComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }
    }
}
