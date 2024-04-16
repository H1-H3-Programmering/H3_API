﻿using ICE_Repository.Context;
using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repository.Repositories
{
    public class RecipeRepo : IRecipeRepo
    {
        private readonly DataContext context;
        public RecipeRepo(DataContext data)
        {
            this.context = data;
        }

        public Recipe Create(Recipe recipe)
        {
            // Context is our Database
            context.Recipes.Add(recipe);
            context.SaveChanges();
            return recipe;
        }

        public List<Recipe> GetAll()
        {
            return context.Recipes.ToList();
        }

        public Recipe UpdateById(int id, Recipe updatedRecipe)
        {
            var recipe = context.Recipes.FirstOrDefault(r => r.RecipeId == id);

            if (recipe != null)
            {
                recipe.Name = updatedRecipe.Name;
                recipe.Description = updatedRecipe.Description;
                recipe.Origin = updatedRecipe.Origin;
                recipe.Instructions = updatedRecipe.Instructions;
                recipe.Difficulty = updatedRecipe.Difficulty;
                recipe.PreperationTime = updatedRecipe.PreperationTime;
                recipe.RecipeTagId = updatedRecipe.RecipeTagId;
                recipe.CommentId = updatedRecipe.CommentId;

                context.SaveChanges();
            }

            return recipe;
        }

        public Recipe DeleteById(int id)
        {
            var recipe = context.Recipes.FirstOrDefault(r => r.RecipeId == id);

            if (recipe != null)
            {
                context.Recipes.Remove(recipe);
                context.SaveChanges();
            }
            return recipe;
        }
    }
}
