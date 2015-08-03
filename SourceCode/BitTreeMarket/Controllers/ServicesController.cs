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
    public class ServicesController : Controller
    {
        private IServicesAdapter _adapter;

        public ServicesController()
        {
            _adapter = new ServicesDataAdapter();
        }

        public ServicesController(IServicesAdapter adapter)
        {
            _adapter = adapter;
        }


        public ActionResult Index()
       {
           ServicesVm svm = _adapter.GetServices();


           return View(svm);
        }
    }
}