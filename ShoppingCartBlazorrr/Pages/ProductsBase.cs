using Microsoft.AspNetCore.Components;
using ShoppingCart.Models.DTOs;
using ShoppingCartBlazorrr.Services.Contract;

namespace ShoppingCartBlazorrr.Pages
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
        protected IOrderedEnumerable<IGrouping<int, ProductDto>> GetGroupedProductsByCategory()
        {
            return from product in Products
                   group product by product.CategoryId into prodByCatGroup
                   orderby prodByCatGroup.Key
                   select prodByCatGroup; 
        }
        protected string GetCategoryName(IGrouping<int,ProductDto> groupedProductDtos)
        {
            return groupedProductDtos.FirstOrDefault(pg=>pg.CategoryId==groupedProductDtos.Key).CategoryName;
        }
    }
}
