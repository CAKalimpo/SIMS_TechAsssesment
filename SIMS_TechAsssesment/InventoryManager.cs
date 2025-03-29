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
            // this Any() LINQ Method, check atleast one element if it matches:
            // if the Product ID is already exists
            // for easy understanding of lambda:
                            // for each product symbolized as p compares the Product ID itself
                            // if found, this will prevent duplicate entry of the product
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

            // this FirstOrDefault() LINQ Method, check the first element that matches a condition 
            // e.g: if the product contains with product ID exactly as user input. It will automatically
                                                 // remove the product itself  
            var product = products.FirstOrDefault(p => p.ProductId == p.ProductId);
            // this condition checks if the product is null
            if(product == null)
            {
                Console.WriteLine("Product not found");
                return;
            }
            // otherwise, product will be removed
            products.Remove(product);
            Console.WriteLine("****************************");
            Console.WriteLine("Product removed successfully");
        }
        public void UpdateProduct(int productId, int newQuantity)
        {
            // this condition checks newly entered quantity if it's less than zero
            if(newQuantity < 0)
            {
                Console.WriteLine("Quantity cannot be negative");
            }
            // this FirstOrDefault() LINQ Method, check the first element that matches a condition 
            // e.g: if the product contains with product ID exactly as user input. It will update
                                                     // the quantity of its product  
            var product = products.FirstOrDefault(p => p.ProductId == p.ProductId);
            // this condition checks if the product is null
            if (product == null)
            {
                Console.WriteLine("Product not found");
                return;
            }
            // therefore, the quantity will be updated 
            product.QuantityInStock = newQuantity;
            Console.WriteLine("****************************");
            Console.WriteLine("Product updated successfully!");
        }
        public void ListProduct()
        {
            // this condition checks the product list, if empty then will return 
            if(!products.Any())
            {
                Console.WriteLine("Inventory is empty");
                return;
            }
            // it will display the list of inventory that user input has
            Console.WriteLine("\n **** List of Inventory **** ");
            foreach(var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Quantity: {product.QuantityInStock}, Price: {product.Price} ");
            }
        }
        public decimal GetTotalValue()
        {
            // this return value display the total inventory by quantity and its price
            return products.Sum(p => p.QuantityInStock * p.Price);
        }

    }
}