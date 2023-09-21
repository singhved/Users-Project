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
        public PartialViewResult Page(int? row, int offset = 0)
        {
            ViewBag.row = row;
            ViewBag.offset = offset;
            ViewBag.Data = Name;
            ViewBag.Address = Address;
            return PartialView();
        }
        // Partial View for Searching
        //public PartialViewResult Getusers(int? row , int? offset , string Data = null)
        //{
        //    ViewBag.row = row;
        //    ViewBag.offset = offset;
        //    ViewBag.Data = Data;
        //    return PartialView();
        //}
    }
}