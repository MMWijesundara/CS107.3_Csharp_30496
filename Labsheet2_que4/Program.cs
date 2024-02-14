using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet2_que4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product Name: ");
            string product_name = Console.ReadLine();
            Console.WriteLine("Enter Product price: ");
            double price = double.Parse(Console.ReadLine());   

            Product product1 = new Product( product_name ,  price);
            Console.WriteLine("\nProduct Name is: "+product1.ProductName);
            Console.WriteLine("Product price is: "+product1.price);

            Console.ReadLine();

        }
    }
}
