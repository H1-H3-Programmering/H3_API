using ICE_Repository.Context;
using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using System.Collections.Generic;
using System.Linq;

namespace ICE_Repository.Repositories
{
    public class UserPreferenceRepo : IUserPreferenceRepo
    {
        private readonly DataContext context;

        public UserPreferenceRepo(DataContext data)
        {
            this.context = data;
        }

        public UserPreference Create(UserPreference userPreference)
        {
            context.UserPreferences.Add(userPreference);
            context.SaveChanges();
            return userPreference;
        }

        public List<UserPreference> GetAll()
        {
            return context.UserPreferences.ToList();
        }

        public UserPreference UpdateById(int id, UserPreference updatedUserPreference)
        {
            var userPreference = context.UserPreferences.FirstOrDefault(up => up.PreferenceId == id);

            if (userPreference != null)
            {
                
                userPreference.PreferenceType = updatedUserPreference.PreferenceType;
                userPreference.PreferenceDescription = updatedUserPreference.PreferenceDescription;
                userPreference.DietaryPreferenceId = updatedUserPreference.DietaryPreferenceId;

                context.SaveChanges();
            }

            return userPreference;
        }

        public UserPreference DeleteById(int id)
        {
            var userPreference = context.UserPreferences.FirstOrDefault(up => up.PreferenceId == id);

            if (userPreference != null)
            {
                context.UserPreferences.Remove(userPreference);
                context.SaveChanges();
            }

            return userPreference;
        }
    }
}
