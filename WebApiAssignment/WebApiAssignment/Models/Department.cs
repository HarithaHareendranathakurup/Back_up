using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApiAssignment.Models
{
    public class Department
    {
        [Required(ErrorMessage = "id is required")]
        public int Department_ID { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<EmployeeDetails> EmployeeDetails  { get; set; }

    }
}