using BlazorProductManager.Data;
using BlazorProductManager.Models;
using BlazorProductManager.Repository;

namespace BlazorProductManager.Services
{
    public class ProductService
    {
        private readonly IProductRepository repository;

        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }

        public List<Product> GetAllProducts()
        {
            return this.repository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return this.repository.GetById(id);
        }

        public void AddProduct(Product model)
        {
            this.repository.Add(model);
            this.repository.Save();
        }

        public void UpdateProduct(Product model)
        {
            this.repository.Update(model);
            this.repository.Save();
        }

        public void DeleteProduct(int id)
        {
            this.repository.Remove(id);
            this.repository.Save();
        }

        public int GetNewProductId()
        {
            var lastItem = this.repository.GetLastItem();
            return lastItem != null ? lastItem.Id + 1 : 1;
        }
    }
}
