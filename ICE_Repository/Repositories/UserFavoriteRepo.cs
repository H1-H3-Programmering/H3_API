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
    public class UserFavoriteRepo : IUserFavoriteRepo
    {
        private readonly DataContext context;
        public UserFavoriteRepo(DataContext data)
        {
            this.context = data;
        }

        public UserFavorite Create(UserFavorite column)
        {
            // Context is our Database
            context.UserFavorites.Add(column);
            context.SaveChanges();
            return column;
        }

        public List<UserFavorite> GetAll()
        {
            return context.UserFavorites.ToList();
        }

        public UserFavorite UpdateById(int id, UserFavorite updatedColumn)
        {
            var column = context.UserFavorites.FirstOrDefault(c => c.UserFavoriteId == id);

            if (column != null)
            {
                column.UserFavoriteRecipeJOINs = updatedColumn.UserFavoriteRecipeJOINs;
                column.UserId = updatedColumn.UserId;

                context.SaveChanges();
            }

            return column;
        }

        public UserFavorite DeleteById(int id)
        {
            var column = context.UserFavorites.FirstOrDefault(c => c.UserFavoriteId == id);

            if (column != null)
            {
                context.UserFavorites.Remove(column);
                context.SaveChanges();
            }
            return column;
        }
    }
}
