using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_7
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Book book1 = new Book("Harry potter", "JK Rowling");

            Console.WriteLine(book1.Title);
            Console.WriteLine(book1.Author);
            Console.ReadLine();
            Console.WriteLine("new line");

        }
    }
}
