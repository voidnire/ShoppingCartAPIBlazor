using System.Collections.Generic;
using System.Threading.Tasks;
using ShoppingCart.Models.DTOs;

namespace ShoppingCartBlazor.Services.Contract
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();


    }
}
