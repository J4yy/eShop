using eShop.ViewModels.Catalog.Products;
using eShop.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.WebApp.Models
{
    public class HomeViewModel
    {
        public List<SlideVm> Slides { get; set; }

        public List<ProductVm> FeaturedProducts { get; set; }

        public List<ProductVm> LatestProducts { get; set; }
    }
}