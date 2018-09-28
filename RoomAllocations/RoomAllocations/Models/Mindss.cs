using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RoomAllocations.Models
{
    public class Mindss
    {
        [Key]
        public int MNO { get; set; }
        [Display(Name = "MID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name required")]
        public string MID { get; set; }
        [Display(Name = "MindName")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "MindName required")]
        public string MindName{get;set;}
        [Display(Name = "TrackName")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "TrackName required")]
        public string TrackName { get; set; }
        
     
    }
}