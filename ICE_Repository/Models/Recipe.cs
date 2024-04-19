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
        [JsonIgnore]public List<UserFavoriteRecipeJOIN>? UserFavorites { get; set; }
        [JsonIgnore]public List<RecipeTag>? RecipeTag { get; set; }
        [JsonIgnore]public List<Comments>? CommentId { get; set; }
    }
}
