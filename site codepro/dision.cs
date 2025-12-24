using System.Collections.Generic;
using System.Linq;

namespace OnlineShop
{
    public class Cart
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(int productId)
        {
            products.RemoveAll(p => p.Id == productId);
        }

        public decimal GetTotalPrice()
        {
            return products.Sum(p => p.Price);
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
