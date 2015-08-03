using BitTreeMarket.Hubs;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace BitTreeMarket.Controllers
{
    public abstract class BaseController : ApiController
    {
        protected readonly Lazy<IHubContext> ShoppingCartHub = new Lazy<IHubContext>(() => GlobalHost.ConnectionManager.GetHubContext<ShoppingCartHub>());
        protected readonly Lazy<IHubContext> AdminHub = new Lazy<IHubContext>(() => GlobalHost.ConnectionManager.GetHubContext<AdminHub>());
    }
}