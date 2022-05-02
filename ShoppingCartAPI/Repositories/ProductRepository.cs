using Microsoft.EntityFrameworkCore;
using ShoppingCartAPI.Data;
using ShoppingCartAPI.Entities;
using ShoppingCartAPI.Repositories.Contracts;

namespace ShoppingCartAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShoppingDbContext shoppingDbContext;

        public ProductRepository(ShoppingDbContext shoppingDbContext) //ctor and double tab to generate / CTRL . 
        {
            this.shoppingDbContext = shoppingDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.shoppingDbContext.ProductCategories.ToListAsync(); //returns from database
            return categories;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems() //returns a collection of product date into the blazor component
        {
            var products = await this.shoppingDbContext.Products.ToListAsync(); //return product date from the database
            return products;
        }
    }
}
