using Student.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student.Controllers
{
    public class StudController : Controller
    {
        // GET: Stud
        public ActionResult Index()
        {
            return View();
        }

        // GET: Stud/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // GET: Stud/Create
        [HttpPost]
        public ActionResult Create(StudModel model)
        {
           string c = "Data Source=G1C2ML15529;Initial Catalog=db;Integrated Security=True";
            SqlConnection con = new SqlConnection(c);
            con.Open();
            string query1 = "insert into Student values(@Id, @Name)";
            SqlCommand a = new SqlCommand(query1, con);
            a.Parameters.AddWithValue("@Id", model.Id);
            a.Parameters.AddWithValue("@Name", model.Name);
            a.ExecuteNonQuery();
            con.Close();
            return View("Create1");
        }
        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(StudModel model)
        {
            string c = "Data Source=G1C2ML15529;Initial Catalog=db;Integrated Security=True";
            SqlConnection con = new SqlConnection(c);
            con.Open();
            string query1 = "delete from Student where Id="+model.Id;
            SqlCommand a = new SqlCommand(query1, con);
            a.ExecuteNonQuery();
            con.Close();
            return View();
        }
        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(StudModel model)
        {
            string c = "Data Source=G1C2ML15529;Initial Catalog=db;Integrated Security=True";
            SqlConnection con = new SqlConnection(c);
            con.Open();
            string query1 = "update Student set Name='"+model.Name+"'where Id=" + model.Id;
            SqlCommand a = new SqlCommand(query1, con);
            a.ExecuteNonQuery();
            con.Close();
            return View();

        }

        // POST: Stud/Create
        // [HttpPost]
        /* public ActionResult Create(FormCollection collection)
         {
             try
             {
                 // TODO: Add insert logic here

                 return RedirectToAction("Index");
             }
             catch
             {
                 return View();
             }
         }*/

    }
}

        