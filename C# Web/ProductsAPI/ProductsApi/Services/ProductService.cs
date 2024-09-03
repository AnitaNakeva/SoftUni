using Microsoft.EntityFrameworkCore;
using ProductsApi.Data;

namespace ProductsApi.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductDbContext data;

        public ProductService(ProductDbContext data)
        {
            this.data = data;
        }

        public List<Product> GetAllProducts()
        {
            return this.data.Products.ToList();
        }

        public Product GetById(int id)
        {
            return this.data.Products.Find(id);
        }

        public Product CreateProduct(string name, string description)
        {
            var product = new Product()
            {
                Name = name,
                Description = description
            };

            this.data.Products.Add(product);
            this.data.SaveChanges();

            return product;

        }

        public void EditProduct(int id, Product product)
        {
            var dbProduct = this.data.Products.Find(id);

            dbProduct.Name = product.Name;
            dbProduct.Description = product.Description;

            this.data.SaveChanges();
        }

        public void EditProductPartially(int id, Product product)
        {
            var dbProduct = this.data.Products.Find(id);

            dbProduct.Name = String.IsNullOrEmpty(product.Name)
                ? dbProduct.Name : product.Name;
            dbProduct.Description = String.IsNullOrEmpty(product.Description)
                ? dbProduct.Description : product.Description;

            this.data.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            var trackedEntity = this.data.Products.Attach(product);

            this.data.Entry(product).Property(p => p.Name).IsModified = true;
            this.data.Entry(product).Property(p => p.Description).IsModified = true;

            this.data.SaveChanges();
        }

        public Product DeleteProduct(int id)
        {
            var product = this.data.Products.Find(id);

            this.data.Products.Remove(product);
            this.data.SaveChanges();

            return product;
        }
    }
}
