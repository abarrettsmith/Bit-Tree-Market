using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BitTreeMarket.Model;

namespace BitTreeMarket.Models
{
    public class ProductVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string ImageLink { get; set; }

        public List<Product> Products { get; set; }

        public int? CategoryId { get; set; }
    }
}