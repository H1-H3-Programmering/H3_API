using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ICE_Repository.Models
{
    public class UserPreference
    {
        [Key]
        public int PreferenceId { get; set; }

        public string? PreferenceType { get; set; }

        public string? PreferenceDescription { get; set; }
        [JsonIgnore]public List<DietaryPreference>? DietaryPreferenceId { get; set; }
    }
}
