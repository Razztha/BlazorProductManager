using BlazorProductManager.Data;
using BlazorProductManager.Models;

namespace BlazorProductManager.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
        //you can add here data operations for product.
    }
}
