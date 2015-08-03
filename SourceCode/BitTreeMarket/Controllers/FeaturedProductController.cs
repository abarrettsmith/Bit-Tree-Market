using BitTreeMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitTreeMarket.Data;
using BitTreeMarket.Adapters;
using BitTreeMarket.Adapters.Data;

namespace BitTreeMarket.Controllers
{
    public class FeaturedProductController : Controller
    {
        private IFeaturedProductsAdapter _adapter;

        public FeaturedProductController()
        {
            _adapter = new FeaturedProductDataAdapter();
        }

        public FeaturedProductController(IFeaturedProductsAdapter adapter)
        {
            _adapter = adapter;
        }


        public ActionResult IndexTest()
       {
           FeaturedProductVm Fvm = _adapter.GetFeaturedProducts();
            

            return View(Fvm);
        }
    }
}