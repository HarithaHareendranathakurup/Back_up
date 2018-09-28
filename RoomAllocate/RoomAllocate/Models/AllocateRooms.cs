using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomAllocate.Models
{
    public class AllocateRooms
    {
        [Key]
        public int SNO { get; set; }

        [ForeignKey("Users")]
        [Index(IsUnique = true)]
        public int MNO { get; set; }

        public Users Users { get; set; }
        [ForeignKey("Roomss")]
       // [Index(IsUnique = true)]
        public int RNO { get; set; }
        public Rooms Roomss { get; set; }
    }
}