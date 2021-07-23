using eShop.ViewModels.Utilities.Slides;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.ApiIntegration
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}