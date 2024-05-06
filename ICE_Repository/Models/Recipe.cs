﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Origin { get; set; }
        public string? Instructions { get; set; }
        public int Difficulty { get; set; }
        public int PreperationTime { get; set; }
        [JsonIgnore] public List<UserFavoriteRecipeJOIN> UserFavoriteRecipeJOINs { get; set; } = new List<UserFavoriteRecipeJOIN>();
        [JsonIgnore] public List<RecipeTag> RecipeTag { get; set; } = new List<RecipeTag>();
        [JsonIgnore] public List<Comments> CommentId { get; set; } = new List<Comments>();
        [JsonIgnore] public List<CategoryRecipeJOIN> CategoryRecipeJOINs { get; set; } = new List<CategoryRecipeJOIN> { };
        [JsonIgnore] public List<RecipeIngredientJOIN> RecipeIngredientJOINs { get; set; } = new List<RecipeIngredientJOIN> { };
    }


    public class RecipeIngredientJOIN
    {
        public int RecipeIngredientJOINId { get; set; }

        public int RecipeId { get; set; }
        public Recipe recipes { get; set; } = new Recipe();

        public int IngredientsId { get; set; }
        public Ingredient Ingredients { get; set; } = new Ingredient();

    }
}
