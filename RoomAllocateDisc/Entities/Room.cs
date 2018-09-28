using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Entities
{
    [Table("RoomDetails")]
    public class Room
    {
        [Key]
        public int RId { get; set; }
        public string RoomName { get; set; }
        public string Subject { get; set; }
        public DateTime startTime { get; set; }
        public DateTime EndTime { get; set; }
        public int NoEmp { get; set; }

       

    }
}
