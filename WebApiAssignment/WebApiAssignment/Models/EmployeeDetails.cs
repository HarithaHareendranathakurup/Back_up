using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApiAssignment.Models
{
    public class EmployeeDetails
    {
        [Required(ErrorMessage = "id is required")]
        public int Employee_ID { get; set; }
        public string EmployeeName { get; set; }

    }
}