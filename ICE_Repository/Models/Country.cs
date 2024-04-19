
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ICE_Repository.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        public string? CountryName { get; set; }

        public string? Continent { get; set; }

        //Navigation Property
        [JsonIgnore] public List<Regions>? Region { get; set; }
        //Navigation Property
        [JsonIgnore] public List<Language>? Language { get; set; }
        //Navigation Property
        [JsonIgnore] public List<Kitchen>? Kitchen { get; set;}
    }
}
