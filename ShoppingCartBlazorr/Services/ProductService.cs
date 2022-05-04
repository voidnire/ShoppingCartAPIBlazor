using ShoppingCart.Models.DTOs;
using ShoppingCartBlazorr.Services.Contract;
using System.Diagnostics;
using System.Net.Http.Json;

namespace ShoppingCartBlazorr.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;
        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product"); //get from json async method will return
                                                                                                               //an ienumerable connection of products(translated data
                return products;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception Message: " + ex.Message);
                throw;
            }
        }


    }
}
