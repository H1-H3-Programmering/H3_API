using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientsId { get; set; }
        public string? Name { get; set; }
        public int CategoryId { get; set; }
    }
}
