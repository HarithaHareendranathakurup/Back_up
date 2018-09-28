using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using WebApiAssignment.Models;

namespace WebApiAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<Department> Obj = null;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51626/");
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

         HttpResponseMessage response = client.GetAsync("api/EmployeeDetails/GetAllDepartment").Result;
            if (response.IsSuccessStatusCode)
            {
                var eResponse = response.Content.ReadAsStringAsync().Result;

                //Deserializing the response recieved from web api and storing into the Employee list  
                Obj = JsonConvert.DeserializeObject<List<Department>>(eResponse);




            }
            return View(Obj);
        }
    }
}
