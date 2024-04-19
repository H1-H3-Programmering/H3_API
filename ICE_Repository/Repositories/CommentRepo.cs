using ICE_Repository.Context;
using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using System.Collections.Generic;
using System.Linq;

namespace ICE_Repository.Repositories
{
    public class CommentRepo : ICommentRepo
    {
        private readonly DataContext context;

        public CommentRepo(DataContext data)
        {
            this.context = data;
        }

        public Comments Create(Comments comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
            return comment;
        }

        public List<Comments> GetAll()
        {
            return context.Comments.ToList();
        }

        public Comments UpdateById(int id, Comments updatedComment)
        {
            var comment = context.Comments.FirstOrDefault(c => c.CommentId == id);

            if (comment != null)
            {
                comment.UserId = updatedComment.UserId;
                comment.RecipeId = updatedComment.RecipeId;
                comment.Text = updatedComment.Text;

                context.SaveChanges();
            }

            return comment;
        }

        public Comments DeleteById(int id)
        {
            var comment = context.Comments.FirstOrDefault(c => c.CommentId == id);

            if (comment != null)
            {
                context.Comments.Remove(comment);
                context.SaveChanges();
            }

            return comment;
        }
    }
}
