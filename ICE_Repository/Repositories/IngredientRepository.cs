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
    public class IngredientRepository : IIngredientRepo
    {
        private readonly DataContext context;
        public IngredientRepository(DataContext data)
        {
            this.context = data;
        }

        public Ingredient Create(Ingredient ingredient)
        {
            // Context is our Database
            context.Ingredients.Add(ingredient);
            context.SaveChanges();
            return ingredient;
        }

        public List<Ingredient> GetAll()
        {
            return context.Ingredients.ToList();
        }

        public Ingredient UpdateById(int id, Ingredient updatedIngredient)
        {
            var column = context.Ingredients.FirstOrDefault(c => c.IngredientsId == id);
            //var column = context.Categories.FirstOrDefault(c => c.CategoryId == id);

            if (column != null)
            {
                column.Name = updatedIngredient.Name;
                column.CategoryId = updatedIngredient.CategoryId;
                column.RecipeId = updatedIngredient.RecipeId;

                context.SaveChanges();
            }

            return column;
        }

        public Ingredient DeleteById(int id)
        {
            var ingredient = context.Ingredients.FirstOrDefault(i => i.IngredientsId == id);

            if (ingredient != null)
            {
                context.Ingredients.Remove(ingredient);
                context.SaveChanges();
            }
            return ingredient;
        }
    }
}
