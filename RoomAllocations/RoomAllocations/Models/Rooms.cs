using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RoomAllocations.Models
{
    public class Rooms
    {
        [Key]
        public int RNO { get; set; }
        [Display(Name = "RID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "RID is required")]
        
        public int RID { get; set; }
        [Display(Name = "BlockName")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "BlockName required")]
        public string BlockName { get; set; }
        [Display(Name = "FloorName")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "FloorName required")]
        public string FloorName { get; set; }
    }
}