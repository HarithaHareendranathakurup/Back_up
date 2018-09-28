using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ProjectWebApi.Models;
using System.Web.Http.Cors;

namespace ProjectWebApi.Controllers
{
    [EnableCors(origins:"http://localhost:4200",headers:"*",methods:"*")]
    public class MindDetailsController : ApiController
    {
        private DBModel db = new DBModel();

        // GET: api/MindDetails
        public IQueryable<MindDetail> GetMindDetails()
        {
            return db.MindDetails;
        }

       
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MindDetailExists(int id)
        {
            return db.MindDetails.Count(e => e.ID == id) > 0;
        }
    }
}