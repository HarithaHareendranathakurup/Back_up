using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampusMinds.Models
{
    public class Minds
    {
        [Key]
        public int MID { get; set; }
        [Display(Name="Name")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Name required")]

        public string Name { get; set; }
        public string Gender { get; set; }
        public string ContactId { get; set; }
        
        public int TrackId { get; set; }
        [ForeignKey("TrackId")]
        public Tracks Tracks { get; set; }
    }
}