using ShoppingCart.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCartBlazorr.Services.Contract
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
    }
}
