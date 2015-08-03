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
    public class CraftsController : Controller
    {
        private ICraftsAdapter _adapter;

        public CraftsController()
        {
            _adapter = new CraftsDataAdapter();
        }

        public CraftsController(ICraftsAdapter adapter)
        {
            _adapter = adapter;
        }


        public ActionResult Index()
       {
           CraftsVm cvm = _adapter.GetCrafts();


           return View(cvm);
        }
    }
}