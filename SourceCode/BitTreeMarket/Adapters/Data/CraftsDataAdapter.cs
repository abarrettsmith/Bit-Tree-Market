using BitTreeMarket.Data;
using BitTreeMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitTreeMarket.Adapters.Data
{
    public class CraftsDataAdapter : ICraftsAdapter
    {
        public CraftsVm GetCrafts()
        {

            using (BitTreeMarketDbContext db = new BitTreeMarketDbContext())
            {
                return new CraftsVm()
                {
                    Crafts = db.Products.Where(c => c.CategoryId == 18).Select(a => new ProductVm()
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