using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Users.Models;

namespace Users.Controllers
{
    public class PaginationController : Controller
    {
        // GET: Pagination
        public ActionResult Index()
        {
            return View();
        }
        //Partial View for Pagination
        public PartialViewResult Page(int? row, string Column, string Table, int offset = 0, string Data = null)
        {
            ViewBag.row = row;
            ViewBag.Column = Column;
            ViewBag.Table = Table;
            ViewBag.offset = offset;
            ViewBag.Data = Data;
            return PartialView();
        }
    }
}