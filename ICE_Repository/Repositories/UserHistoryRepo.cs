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
    public class UserHistoryRepo : IUserHistoryRepo
    {
        private readonly DataContext context;

        public UserHistoryRepo(DataContext data)
        {
            this.context = data;
        }

        public UserHistory Create(UserHistory userHistory)
        {
            context.UserHistories.Add(userHistory);
            context.SaveChanges();
            return userHistory;
        }

        public List<UserHistory> GetAll()
        {
            return context.UserHistories.ToList();
        }

        public UserHistory UpdateById(int id, UserHistory updatedUserHistory)
        {
            var userHistory = context.UserHistories.FirstOrDefault(uh => uh.UserHistoryId == id);

            if (userHistory != null)
            {
                userHistory.UserId = updatedUserHistory.UserId;
                userHistory.RecipeId = updatedUserHistory.RecipeId;

                context.SaveChanges();
            }

            return userHistory;
        }

        public UserHistory DeleteById(int id)
        {
            var userHistory = context.UserHistories.FirstOrDefault(uh => uh.UserHistoryId == id);

            if (userHistory != null)
            {
                context.UserHistories.Remove(userHistory);
                context.SaveChanges();
            }
            return userHistory;
        }
    }
}
