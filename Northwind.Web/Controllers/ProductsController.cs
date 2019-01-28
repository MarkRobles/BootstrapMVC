using Northwind.Web.Clases;
using Northwind.Web.DataContext;
using Northwind.Web.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.Web.Controllers
{
    public class ProductsController : Controller
    {
       // NorhtwindEntities db = new NorhtwindEntities();
        clsProducts _producto = new clsProducts();

        // GET: Products
        public ActionResult Index(int ?page)
        {
            List<Product> productos = new List<Product>();
            productos = _producto.GetTs();


            int pageSize = 5;
            int pageNumber = (page ?? 1);
            //Convertir modelo a su representacion paginada
            return View(productos.ToPagedList(pageNumber, pageSize));

        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            Product _product = new Product();

            _product = _producto.GetT(new Models.Product { ProductID= 1});
            return View(_product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create( Product Product)
        {
            try
            {
                // TODO: Add insert logic here
                _producto.CrudT(Product,ECrud.Alta);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
