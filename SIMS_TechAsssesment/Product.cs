namespace SIMS_TechAsssesment
{
    class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }
        public decimal Price { get; set; }
        
     public Product(int productId, string productName, int quantityInStock, decimal price)
        {
            ProductId = productId;
            ProductName = productName;
            QuantityInStock = quantityInStock;
            Price = price;
        }
    }
}