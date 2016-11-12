using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer 
{
    public class ProductRepository
    {
        private readonly ProductManagement Products;

        public ProductRepository()
        {
            Products = new ProductManagement();
        }

        public Product GetById(Guid id)
        {
            return Products.Products.FirstOrDefault(prod => prod.Id == id);
        }

        public void Remove(Guid id)
        {
            Products.Products.Remove(Products.Products.FirstOrDefault(prod => prod.Id == id));
        }

        public void Create(Product p)
        {
            Products.Products.Add(p);
        }

        public void Update(Product p)
        {
            Products.Products.Update(p);
        }

        public IEnumerable<Product> GetAll()
        {
            return Products.Products.ToList();
        }

        public IEnumerable<Product> GetProductByPrice(int price)
        {
            return Products.Products.Where(prod => prod.Price == price);
        }
    }
}