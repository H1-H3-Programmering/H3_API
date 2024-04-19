using ICE_Repository.Context;
using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using System.Collections.Generic;
using System.Linq;

namespace ICE_Repository.Repositories
{
    public class DietaryPreferenceRepo : IDietaryPreferenceRepo
    {
        private readonly DataContext context;

        public DietaryPreferenceRepo(DataContext data)
        {
            this.context = data;
        }

        public DietaryPreference Create(DietaryPreference dietaryPreference)
        {
            context.DietaryPreferences.Add(dietaryPreference);
            context.SaveChanges();
            return dietaryPreference;
        }

        public List<DietaryPreference> GetAll()
        {
            return context.DietaryPreferences.ToList();
        }
        public DietaryPreference DeleteById(int id)
        {
            throw new NotImplementedException("DeleteById operation is not supported for RecipeTagRepo.");
        }

        public DietaryPreference UpdateById(int id, DietaryPreference updatedEntity)
        {
            throw new NotImplementedException("UpdateById operation is not supported for RecipeTagRepo.");
        }
    }
}
