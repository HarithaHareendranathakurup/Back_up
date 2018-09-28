using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomAllocations.Models
{
    public class UserRoom
    {
        [ForeignKey("MNO")]
        [Index(IsUnique = true)]
        public int MNO { get; set; }
        [ForeignKey("RNO")]
        [Index(IsUnique = true)]
        public int RNO { get; set; }
    }
}