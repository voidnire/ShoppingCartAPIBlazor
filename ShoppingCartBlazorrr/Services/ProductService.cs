using Newtonsoft.Json;
using ShoppingCart.Models.DTOs;
using ShoppingCartBlazorrr.Services.Contract;
using System.Diagnostics;
using System.Net.Http.Json;

namespace ShoppingCartBlazorrr.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;
        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDto>> GetItems() //errors here?
        {
            //try
            //{
                //var teste = this.httpClient.GetAsync("api/Product");
                //var prod2 = JsonConvert.DeserializeObject<ProductDto>(teste.ToString());
                var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product"); //get from json async method will return
                                                                                                               //an ienumerable connection of products(translated data
                return products;
            //}
            //catch (Exception ex)
            //{
                //Debug.WriteLine("Exception Message: " + ex.Message);
                //throw;
            //}
        }


    }
}
