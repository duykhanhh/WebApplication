using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.ViewModels.Catalog.Products;

using WebApplication.ViewModels.Common;

namespace WebApplication.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);
        Task<List<ProductViewModel>> GetAll();
    }
}
