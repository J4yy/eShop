using eShop.Application.System.Roles;
using eShop.Data.EF;
using eShop.Data.Entities;
using eShop.ViewModels.System.Roles;
using eShop.ViewModels.Utilities.Slides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly eShopDbContext _context;

        public SlideService(eShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<SlideVm>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SlideVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image
                }).ToListAsync();

            return slides;
        }
    }
}