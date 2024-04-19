using ICE_Repository.Context;
using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using System.Collections.Generic;
using System.Linq;

namespace ICE_Repository.Repositories
{
    public class RecipeTagRepo : IRecipeTagRepo
    {
        private readonly DataContext context;

        public RecipeTagRepo(DataContext data)
        {
            this.context = data;
        }

        public RecipeTag Create(RecipeTag recipeTag)
        {
            context.RecipeTags.Add(recipeTag);
            context.SaveChanges();
            return recipeTag;
        }

        public List<RecipeTag> GetAll()
        {
            return context.RecipeTags.ToList();
        }

        public RecipeTag DeleteById(int id)
        {
            throw new NotImplementedException("DeleteById operation is not supported for RecipeTagRepo.");
        }

        public RecipeTag UpdateById(int id, RecipeTag updatedEntity)
        {
            throw new NotImplementedException("UpdateById operation is not supported for RecipeTagRepo.");
        }

        public RecipeTag DeleteByRecipeId(int recipeId)
        {
            var recipeTags = context.RecipeTags.Where(rt => rt.Recipes.RecipeId == recipeId).ToList();

            if (recipeTags != null)
            {
                context.RecipeTags.RemoveRange(recipeTags);
                context.SaveChanges();
            }
            return null;
        }

    }
}
