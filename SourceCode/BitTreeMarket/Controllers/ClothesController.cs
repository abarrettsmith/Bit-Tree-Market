using BitTreeMarket.Adapters;
using BitTreeMarket.Adapters.Data;
using BitTreeMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitTreeMarket.Controllers
{
    public class ClothesController : Controller
    {
        private IClothesAdapter _adapter;

        public ClothesController()
        {
            _adapter = new ClothesDataAdapter();
        }

        public ClothesController(IClothesAdapter adapter)
        {
            _adapter = adapter;
        }



        // GET: FeaturedProduct
        public ActionResult Index()
       {
           ClothesVm cvm = _adapter.GetClothes();


           return View(cvm);
        }
    }
}