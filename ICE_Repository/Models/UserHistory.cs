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
    public class UserHistory
    {
        [Key]
        public int UserHistoryId { get; set; }

        public int UserId { get; set; }
        [JsonIgnore] public Users User { get; set; } = new Users();

        public int RecipeId { get; set; }
        [JsonIgnore] public Recipe Recipe { get; set; } = new Recipe();
    }
}
