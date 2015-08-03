using BitTreeMarket.Data;
using BitTreeMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitTreeMarket.Adapters.Data
{
    public class HomeGardenDataAdapter : IHomeGardenAdapter
    {
        public HomeGardenVm GetHomeGarden()
        {

            using (BitTreeMarketDbContext db = new BitTreeMarketDbContext())
            {
                return new HomeGardenVm()
                {
                    HomeGarden = db.Products.Where(hg => hg.CategoryId == 20).Select(a => new ProductVm()
                    {
                        Id = a.Id,
                        Details = a.Details,
                        Name = a.Name,
                        CategoryId = a.CategoryId,
                        ImageLink = a.ImageLink
                    }).ToList()
                };

            }
        }
    }
}