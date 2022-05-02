using ShoppingCartAPI.Entities;

namespace ShoppingCartAPI.Repositories.Contracts
{
    public interface IProductRepository //first the interface is generated, then the iproductrepository class in the same folder
    {
        Task<IEnumerable<Product>> GetItems(); //return generic task objects
        Task<IEnumerable<ProductCategory >> GetCategories();
        Task<Product> GetItem(int id);
        Task<ProductCategory> GetCategory(int id);
    }
}
