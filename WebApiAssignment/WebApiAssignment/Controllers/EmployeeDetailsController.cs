using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAssignment.Models;

namespace WebApiAssignment.Controllers
{
    public class EmployeeDetailsController : ApiController
    {
        public static List<Department> Departments;
        public EmployeeDetailsController()
        {
            Departments = new List<Department>() {
                new Department{ Department_ID = 1,
                                DepartmentName = "CSE",
                                EmployeeDetails = new List<EmployeeDetails>{
                                                new EmployeeDetails{ Employee_ID = 1, EmployeeName = "John"},
                                                new EmployeeDetails{ Employee_ID = 2, EmployeeName = "Martin"}
                                                            }
                },
                new Department{ Department_ID = 2,
                                DepartmentName = "Mechanical",
                                EmployeeDetails = new List<EmployeeDetails>{
                                                new EmployeeDetails{ Employee_ID = 3, EmployeeName = "Mathew"},
                                                new EmployeeDetails{ Employee_ID = 4, EmployeeName = "albert"}

                }
            }
        };
        }

        [HttpGet]
        public List<Department> GetAllDepartment()
        {
            return Departments;
        }
        

    }
}
