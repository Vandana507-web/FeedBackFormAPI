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
        
        public string? Int_discussion { get; set; }
        public string? IntTime { get; set; }
        public string? Post { get; set; }
        public decimal? Phoneno { get; set; }
        public string? Topics { get; set; }
        public string? Notes { get; set; }

    }
}
