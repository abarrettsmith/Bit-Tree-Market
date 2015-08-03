using BitTreeMarket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Net.Http;

namespace BitTreeMarket.Controllers
{
    public class AdminController : BaseController
    {
        private readonly IRepository<Product> _repository;

        public AdminController()
            : this(new MemoryRepository<Product>())
        { }

        public AdminController(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public void Put(int id, Product product)
        {
            if (!ModelState.IsValid) throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState));

            product.Id = id;
            var newProduct = _repository.Update(product);
            ShoppingCartHub.Value.Clients.All.updateProductCount(newProduct);
        }
    }
}