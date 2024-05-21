using ICE_Repository.Context;
using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext context;
        public UserRepository(DataContext data)
        {
            this.context = data;
        }

        public Users Create(Users column)
        {
            // Context is our Database
            context.Users.Add(column);
            context.SaveChanges();
            return column;
        }

        public List<Users> GetAll()
        {
            return context.Users.ToList();
        }

        public Users UpdateById(int id, Users updatedColumn)
        {
            var column = context.Users.FirstOrDefault(c => c.UserId == id);

            if (column != null)
            {
                column.Username = updatedColumn.Username;
                column.Email = updatedColumn.Email;
                column.Password = updatedColumn.Password;
                column.CommentId = updatedColumn.CommentId;
                column.UserDietaryPreferenceJOINs = updatedColumn.UserDietaryPreferenceJOINs;
                column.ReviewId = updatedColumn.ReviewId;

                context.SaveChanges();
            }

            return column;
        }

        public Users DeleteById(int id)
        {
            var column = context.Users.FirstOrDefault(c => c.UserId == id);

            if (column != null)
            {
                context.Users.Remove(column);
                context.SaveChanges();
            }
            return column;
        }
    }
}
