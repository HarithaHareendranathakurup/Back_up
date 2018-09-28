using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudentDatabase.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public string Name { get; set; }
    }
}