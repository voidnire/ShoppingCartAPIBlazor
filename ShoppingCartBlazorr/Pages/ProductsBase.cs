using Microsoft.AspNetCore.Components;
using ShoppingCart.Models.DTOs;
using ShoppingCartBlazorr.Services.Contract;

namespace ShoppingCartBlazorr.Pages
{
    public class ProductsBase:ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();  //1 ☕
        }
    }
}
