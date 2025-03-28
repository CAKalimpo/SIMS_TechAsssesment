using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_TechAsssesment
{
   class Program
    {
        static void Main()
        {
            InventoryManager inventory = new InventoryManager();
            while (true)
            {
                Console.WriteLine("\n **** INVENTORY MANAGEMENT SYSTEM **** ");
                Console.WriteLine("1. Add new Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Update Product");
                Console.WriteLine("4. List of Product");
                Console.WriteLine("5. Total of Product");

                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Console.Write("Enter a new Product ID: ");
                        int pID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Product Name: ");
                        string pName = Console.ReadLine();
                        Console.Write("Quantity: ");
                        int pQty = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Price: ");
                        decimal pPrice = (decimal)Convert.ToDouble(Console.ReadLine());
                        inventory.AddProduct(new Product(pID, pName, pQty, pPrice));
                        break;
                    case "2":
                        Console.Write("Enter the Product ID: ");
                        int rpID = Convert.ToInt32(Console.ReadLine());
                        inventory.RemoveProduct(rpID);
                        break;
                    case "3":
                        Console.Write("Enter the Product ID: ");
                        int upID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Quantity: ");
                        int upQty = Convert.ToInt32(Console.ReadLine());
                        inventory.UpdateProduct(upID, upQty);
                        break;
                    case "4":
                        inventory.ListProduct();
                        break;
                    case "5":
                        Console.WriteLine("The total inventory is: " + inventory.GetTotalValue().ToString("F2"));
                        break;
                    case "6":
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }
              
        }
    }
}
