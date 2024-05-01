using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientsId { get; set; }
        public string? Name { get; set; }
        public int CategoryId { get; set; }
       [JsonIgnore]public Category category { get; set; }
        public int RecipeId { get; set; }
        [JsonIgnore]public Recipe recipes { get; set; }
    }

    public class IngredientCategoryJOIN
    {
        [Key] public int UserFavoriteRecipeJOINId { get; set; }

        public int UserFavoriteId { get; set; }
        [JsonIgnore] public UserFavorite? UserFavorite { get; set; }

        public int RecipeId { get; set; }
        [JsonIgnore] public Recipe? Recipe { get; set; }
    }
}
