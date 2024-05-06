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
        [JsonIgnore]public List<CategoryRecipeJOIN> CategoryRecipeJOINs { get; set; } = new List<CategoryRecipeJOIN>();
    }

    public class CategoryRecipeJOIN
    {
        [Key] public int CategoryRecipeJOINId { get; set; }

        public int CategoryId { get; set; }
        [JsonIgnore] public Category category { get; set; } = new Category();

        public int RecipeId { get; set; }
        [JsonIgnore] public Recipe Recipe { get; set; } = new Recipe();
    }
}
