using Microsoft.AspNetCore.Components;
using ShoppingCart.Models.DTOs;

namespace ShoppingCartBlazorrr.Pages
{
    public class DisplayProductsBase:ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
