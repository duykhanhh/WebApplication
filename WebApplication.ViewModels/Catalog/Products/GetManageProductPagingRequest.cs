using System.Collections.Generic;
using WebApplication.ViewModels.Common;

namespace WebApplication.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string KeyWord { get; set; }

        public List<int> categoryIds { get; set; }
    }
}
