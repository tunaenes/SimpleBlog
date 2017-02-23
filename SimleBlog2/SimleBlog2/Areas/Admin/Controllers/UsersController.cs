using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimleBlog2.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult Index()
        {
            return Content("Index Screen");
        }
        public ActionResult List()
        {
            return Content("List Screen");
        }
        public ActionResult Edit(int id=0)
        {
            return Content("Edit Screen"+id.ToString());
        }
    }
}