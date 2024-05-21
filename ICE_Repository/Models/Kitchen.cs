using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class Kitchen
    {
        [Key]
        public int KitchenId { get; set; }
        public string? Name { get; set; }
        public string? Continent { get; set; }
        public string? Region { get; set; }
        public int CountryId { get; set; }
        [JsonIgnore] public Country Country { get; set; } = new Country();
        public int RecipeId { get; set; }
        [JsonIgnore] public Recipe recipe { get; set; } = new Recipe();
    }
}
