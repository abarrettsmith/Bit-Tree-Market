using BitTreeMarket.Adapters;
using BitTreeMarket.Adapters.Data;
using BitTreeMarket.Data;
using BitTreeMarket.Model;
using BitTreeMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace BitTreeMarket.Controllers
{
    public class HomeController : Controller
    {
        private IFeaturedProductsAdapter _adapter;

        public HomeController()
        {
            _adapter = new FeaturedProductDataAdapter();
        }

        public HomeController(IFeaturedProductsAdapter adapter)
        {
            _adapter = adapter;
        }

        private BitTreeMarketDbContext db = new BitTreeMarketDbContext();

        // START PRODUCT PAGES
        public ActionResult FirstSix()
        {
            FirstVm pvm = _adapter.FirstSix();

            return View(pvm);
        }

        public ActionResult SecondSix()
        {
            SecondVm pvm = _adapter.SecondSix();

            return View(pvm);
        }

        public ActionResult ThirdSix()
        {
            ThirdVm pvm = _adapter.ThirdSix();

            return View(pvm);
        }

        public ActionResult FourthSix()
        {
            FourthVm pvm = _adapter.FourthSix();

            return View(pvm);
        }
        // END PRODUCT PAGES





        
        public ActionResult Index()
        {
            FeaturedProductVm Fvm = _adapter.GetFeaturedProducts();


            return View(Fvm);
        }

        public ActionResult Details(int id)
        {
            DetailsVm dvm = new DetailsVm();
            using (BitTreeMarketDbContext db = new BitTreeMarketDbContext())
            {
                var nameResults = db.Products.FirstOrDefault(p => p.Id == id);
                dvm.Products = nameResults;
            }
            return View(dvm);
        }


        public ActionResult Admin()
        {
            ViewBag.Message = "Admin Page.";

            return View();
        }
        //// POST: /Account/LogOff

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult LogOff()
        //{
        //    AuthenticationManager.SignOut();
        //    return RedirectToAction("Index", "Home");
        //}
    }

}