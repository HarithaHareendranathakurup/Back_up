using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using UploadImage.Models;



namespace UploadImage.Controllers
{
    public class ImageController : ApiController
    {
        [HttpPost]
        [Route("api/UploadImage")]
        public HttpResponseMessage UploadImage()
        {
            byte[] bytes;
            string imageName = null;
            var httpRequest = HttpContext.Current.Request;
            //Upload Image
            var postedFile = httpRequest.Files["Image"];
            byte[] fileData = null;
            using (var binaryReader = new BinaryReader(postedFile.InputStream))
            {
                fileData = binaryReader.ReadBytes(postedFile.ContentLength);
            }
            //var image = Image.FromFile("D:/Angular Sweet Alert Added/Saswat_api/src/assets");
            //Create custom filename
            //imageName = new String(Path.GetFileNameWithoutExtension(postedFile.FileName).Take(10).ToArray()).Replace(" ", "-");
            //imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(postedFile.FileName);
            //var filePath = HttpContext.Current.Server.MapPath($"~/Image/{imageName}");
            // postedFile.SaveAs(filePath);
            byte[] bytesarray = new byte[(int)postedFile.ContentLength]; 
            //var ms = new MemoryStream();
            //image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            // bytes = ms.ToArray();

            //Save to DB
            using (ImageLibraryEntities db=new ImageLibraryEntities())
            {
                ImageLib image = new ImageLib()
                {
                    ImageName=imageName
                };
                byte[] imageToByteArray(System.Drawing.Image imageIn)
                {
                    MemoryStream ms = new MemoryStream();
                    imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                    return ms.ToArray();
                }
                db.ImageLibs.Add(image);
                db.SaveChanges();
            }
            
            return Request.CreateResponse(HttpStatusCode.Created);
        }
    }
}
