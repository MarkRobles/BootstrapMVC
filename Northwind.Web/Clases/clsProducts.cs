using Northwind.Web.DataContext;
using Northwind.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Web.Clases
{
    public class clsProducts
    {
        NorhtwindEntities db = new NorhtwindEntities();

        public void CrudT(Product value, ECrud Accion)
        {
            db.CrudProducts(
                value.ProductID,
                value.ProductName,
                value.SupplierID,
                value.CategoryID,
                value.QuantityPerUnit,
                value.UnitPrice,
                value.UnitsInStock,
                value.UnitsOnOrder,
                value.ReorderLevel,
                value.Discontinued,
                (short)Accion);

        }

        public Product GetT(Product value)
        {
            return db.GetProduct(value.ProductID).ToList().Select(x => new Product
            {
                ProductName = x.ProductName,
                SupplierID = x.SupplierID,
                CategoryID = x.CategoryID,
                QuantityPerUnit = x.QuantityPerUnit,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock,
                UnitsOnOrder = x.UnitsOnOrder,
                ReorderLevel = x.ReorderLevel,
                Discontinued = x.Discontinued
            }).ToList().First();
        }

        public List<Product> GetTs()
        {
            return db.GetProduct(null).ToList().Select(x => new Product
            {
                ProductName = x.ProductName,
                SupplierID = x.SupplierID,
                CategoryID = x.CategoryID,
                QuantityPerUnit = x.QuantityPerUnit,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock,
                UnitsOnOrder = x.UnitsOnOrder,
                ReorderLevel = x.ReorderLevel,
                Discontinued = x.Discontinued
            }).ToList();
        }
    }
}