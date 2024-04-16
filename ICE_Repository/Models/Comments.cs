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
    public class Comments
    {
        [Key]
        public int CommentId { get; set; }

        public int UserId { get; set; }
        public Users User { get; set; }

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }

        public string Text { get; set; }
    }
}
