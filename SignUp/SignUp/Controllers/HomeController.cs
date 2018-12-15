using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignUp.Models;

namespace SignUp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Table u, HttpPostedFileBase file)
        {
            string path;
            if (file != null)
            {
                try
                {
                    path = Path.Combine(Server.MapPath("~/Images"), path.GetFileName(file.FileName));
                    file.SaveAs(path);
                    u.Image = "/Images/" + path.getfileName(file.FileName);
                    obj.Tables.Add(u);
                    obj.Savechanges();

                }
                catch (Exception)
                {

                }

            }
            return View();


        }
}
    
}
