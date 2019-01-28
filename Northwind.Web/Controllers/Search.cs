using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.Web.Controllers
{
    public class Search : Controller
    {

        DataContext.NorhtwindEntities _context = new DataContext.NorhtwindEntities();
        [HttpPost]
        public ActionResult Index(string searchquery, string fromcontroller)
        {
            switch (fromcontroller)
            {
                case "Products":
                    return RedirectToAction("SearchProductsResult", new
                    {
                        query = searchquery
                    });
                case "Customers":
                    return RedirectToAction("SearchCustomersResult", new
                    {
                        query = searchquery
                    });
                case "Employees":
                    return RedirectToAction("SearchEmployeesResult", new
                    {
                        query = searchquery
                    });
            }
            return View();
        }
        //public ActionResult SearchCustomersResult(string query)
        //{
        //    //ViewBag.SearchQuery = query;
        //    //var results = _context.Customers.Where(p => p.CompanyName.
        //    //Contains(query)
        //    //|| p.ContactName.Contains(query)
        //    //|| p.City.Contains(query)
        //    //|| p.Country.Contains(query)).ToList();
        //    //return View(results);
        //}
    }
}