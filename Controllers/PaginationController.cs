using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Users.Controllers
{
    public class PaginationController : Controller
    {
        // GET: Pagination
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Page(int? row,int? offset)
        {
            ViewBag.row = row;
            ViewBag.offset = offset;
            return PartialView();
        }
    }
}