﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        public string CountryName { get; set; }

        public string Continent { get; set; }

        //Navigation Property
        public List<Regions> Region { get; set; }
        //Navigation Property
        public List<Language> Language { get; set; }
        //Navigation Property
        public List<Kitchen> Kitchen { get; set;}
    }
}
