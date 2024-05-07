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
        public List<Ingredient> ingredients { get; set; } = new List<Ingredient> { };
    }
}
