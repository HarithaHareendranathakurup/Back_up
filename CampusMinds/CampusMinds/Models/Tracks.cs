using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace CampusMinds.Models
{
    public class Tracks
    {
        [Key]
        public int Trackid { get; set; }
        public string TrackName { get; set; }
        public int RoomNo { get; set; }
        public string LeadName { get; set; }
    }
}