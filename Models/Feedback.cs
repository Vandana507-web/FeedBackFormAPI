using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedBackForm.Models
{
    public partial class Feedback
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? timeofinterview { get; set; }
        public string? disussion { get; set; }
        public string? notes { get; set; }
        public decimal? Phoneno { get; set; }
        public List<string>? topics { get; set; }
        public string? posts { get; set; }


    }
}
