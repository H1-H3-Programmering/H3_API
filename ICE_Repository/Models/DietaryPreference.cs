﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ICE_Repository.Models
{
    public class DietaryPreference
    {
        [Key]public int DietaryPreferenceId { get; set; }
        [JsonIgnore] public List<UserDietaryPreferenceJOIN>? UserId { get; set; }


        public int PreferenceId { get; set; }
        [JsonIgnore] public UserPreference? Preference { get; set; }
    }

    public class UserDietaryPreferenceJOIN
    {
        //JOIN class between User and DietaryPreference

        [Key]public int UserDietaryPreferenceJOINId { get; set; }
        //Foreign Key
        public int UserId { get; set; }
        //Navigation Property
        public Users? User { get; set; }

        //Foreign Key
        public int DietaryPreferenceId { get; set; }
        //Navigation Property
        public DietaryPreference? DietaryPreference { get; set; }
    }
}