using BlazorProductManager.Models;

namespace BlazorProductManager.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        //we can still add here product data opertaions but we dont neet to 
        //rewrite because we already add them with generic repository pattern
    }
}
