using System;
using System.Collections.Generic;
using System.Linq;

namespace SIMS_TechAsssesment
{
     class InventoryManager
    {

        // to implement and to optimized the code I've used Lambda expressions and LINQ Methods as well

        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            if(products.Any(p => product.ProductId == p.ProductId))
            {
                Console.WriteLine("****************************");
                Console.WriteLine("Product with this ID already exists");
                return;
            }
            products.Add(product);
            Console.WriteLine("****************************");
            Console.WriteLine("Product added successfully!");
        }
        public void RemoveProduct(int productId)
        {

            // 
            var product = products.FirstOrDefault(p => p.ProductId == p.ProductId);
            if(product == null)
            {
                Console.WriteLine("Product not found");
                return;
            }
            products.Remove(product);
            Console.WriteLine("****************************");
            Console.WriteLine("Product removed successfully");
        }
        public void UpdateProduct(int productId, int newQuantity)
        {
            if(newQuantity < 0)
            {
                Console.WriteLine("Quantity cannot be negative");
            }
            var product = products.FirstOrDefault(p => p.ProductId == p.ProductId);
            if(product == null)
            {
                Console.WriteLine("Product not found");
                return;
            }
            product.QuantityInStock = newQuantity;
            Console.WriteLine("****************************");
            Console.WriteLine("Product updated successfully!");
        }
        public void ListProduct()
        {
            if(!products.Any())
            {
                Console.WriteLine("Inventory is empty");
                return;
            }
            Console.WriteLine("\n **** List of Inventory **** ");
            foreach(var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Quantity: {product.QuantityInStock}, Price: {product.Price} ");
            }
        }
        public decimal GetTotalValue()
        {
            return products.Sum(p => p.QuantityInStock * p.Price);
        }

    }
}