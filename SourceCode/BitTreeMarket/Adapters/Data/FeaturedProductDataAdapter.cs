using BitTreeMarket.Data;
using BitTreeMarket.Model;
using BitTreeMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitTreeMarket.Adapters.Data
{
    public class FeaturedProductDataAdapter : IFeaturedProductsAdapter
    {

        // Featured Products
        public FeaturedProductVm GetFeaturedProducts()
        {

            using (BitTreeMarketDbContext db = new BitTreeMarketDbContext())
            {
                return new FeaturedProductVm()
                {
                    FeaturedProducts = db.Products.Take(12).Select(a => new ProductVm()
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

        // First Set of All
        public FirstVm FirstSix()
        {

            using (BitTreeMarketDbContext db = new BitTreeMarketDbContext())
            {
                return new FirstVm()
                {
                    Firsts = db.Products.Take(6).Select(a => new ProductVm()
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

        // Second Set of All
        public SecondVm SecondSix()
        {

            using (BitTreeMarketDbContext db = new BitTreeMarketDbContext())
            {
                return new SecondVm()
                {
                    Seconds = db.Products.OrderBy(Product => Product.CategoryId).Skip(6).Take(6).Select(a => new ProductVm()
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

        // Third Set of All
        public ThirdVm ThirdSix()
        {

            using (BitTreeMarketDbContext db = new BitTreeMarketDbContext())
            {
                return new ThirdVm()
                {
                    Thirds = db.Products.OrderBy(Product => Product.CategoryId).Skip(12).Take(6).Select(a => new ProductVm()
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

        // Fourth Set of All
        public FourthVm FourthSix()
        {

            using (BitTreeMarketDbContext db = new BitTreeMarketDbContext())
            {
                return new FourthVm()
                {
                    Fourths = db.Products.OrderBy(Product => Product.CategoryId).Skip(18).Take(6).Select(a => new ProductVm()
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