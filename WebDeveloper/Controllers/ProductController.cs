using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        //public ProductData _product = new ProductData();
        // GET: Product
        private IDataAccess<Product> _product;

        public ProductController(IDataAccess<Product> product)
        {
            _product = product;
        }
        public ActionResult Index()
        {
            var product = new ProductData();
            return View(product.GetList());
        }

        public ActionResult Create()
        {
            return View(new Product());
        }

        [HttpPost]

        public ActionResult Create(Product product)
        {
            if(ModelState.IsValid)
            {
                _product.Add(product);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}