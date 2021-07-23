using eShop.ViewModels.Catalog.Categories;
using eShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);

        Task<CategoryVm> GetById(string languageId, int id);
    }
}