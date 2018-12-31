using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Model_Products.Models;

namespace MVC_Model_Products.Controllers
{
    public class ProductController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewProduct()
        {
            ProductDAL dal = new ProductDAL();
            ViewBag.category = dal.Getcategory();
            return View();
        }

        [HttpPost]
        public ActionResult NewProduct(ProductsModel model)
        {
            if (ModelState.IsValid)
            {
                model.productimageaddress = "/Images/" + Guid.NewGuid() + ".jpg";
                model.productimagefile.SaveAs(Server.MapPath(model.productimageaddress));

                ProductDAL dal = new ProductDAL();
                int id = dal.Addproduct(model);
                ViewBag.msg = "Product Added: " + id;
                ModelState.Clear();
                ViewBag.category = dal.Getcategory();
                return View();
            }
            else
            {
                ProductDAL dal = new ProductDAL();
                ViewBag.category = dal.Getcategory();
                return View();
            }
        }

        public ActionResult search()
        {
            List<ProductProjectionModel> list = new List<ProductProjectionModel>();
            return View(list);
        }

        [HttpPost]
        public ActionResult search(string key)
        {
            ProductDAL dal = new ProductDAL();
            List<ProductProjectionModel> list = dal.Search(key);
            return View(list);
        }

        public ActionResult Find(int id)
        {
            ProductDAL dal = new ProductDAL();
            ProductsModel model = dal.Find(id);
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            ProductDAL dal = new ProductDAL();
            ProductsModel model = dal.Find(id);
            ViewBag.category = dal.Getcategory();
            return View(model);
        }
        [HttpPost]

        public ActionResult Edit(ProductsModel model)
        {
            ProductDAL dal = new ProductDAL();
            dal.Update(model.productid, model.productprice, model.productcategory);
            return View("view_updated");
        }

    }
}