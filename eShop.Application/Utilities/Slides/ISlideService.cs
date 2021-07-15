using eShop.ViewModels.System.Roles;
using eShop.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application.Utilities.Slides
{
    public interface ISlideService
    {
        Task<List<SlideVm>> GetAll();
    }
}