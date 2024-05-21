using System;
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
        [JsonIgnore] public List<Ingredient> ingredients { get; set; } = new List<Ingredient> { };
    }
}
