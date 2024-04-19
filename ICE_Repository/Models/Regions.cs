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
    public class Regions
    {
        [Key]
        public int RegionId { get; set; }

        public string? RegionName { get; set; }

        //Foreign Key
        public int CountryId { get; set; }
        //Navigation Property
        [JsonIgnore] public Country? Country { get; set; }
    }
}
