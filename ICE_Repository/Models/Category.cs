using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class Category
    {
        [Key] public int CategoryId { get; set; }
        public string? Name { get; set; }
        [JsonIgnore] List<CategoryRecipeJOIN>? DietaryPreferenceId { get; set; }
    }

    public class CategoryRecipeJOIN
    {
        [Key] public int CategoryRecipeJOINId { get; set; }

        public int CategoryId { get; set; }
        [JsonIgnore] public Category? category { get; set; }

        public int RecipeId { get; set; }
        [JsonIgnore] public Recipe? Recipe { get; set; }
    }
}
