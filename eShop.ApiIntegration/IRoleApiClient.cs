using eShop.ViewModels.Common;
using eShop.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.ApiIntegration
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVm>>> GetAll();
    }
}