using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ICE_Repository.Models
{
    public class RecipeTag
    {
        public int RecipeTagId { get; set; }
        public int RecipeId { get; set; }
        [JsonIgnore] public Recipe Recipes { get; set; } = new Recipe();
        public string? Tag { get; set; }
    }

}
