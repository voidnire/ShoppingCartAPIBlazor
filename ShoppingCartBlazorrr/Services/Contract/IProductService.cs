using ShoppingCart.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCartBlazorrr.Services.Contract
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
    }
}
