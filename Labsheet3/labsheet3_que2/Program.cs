using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet3_que2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(101,"John Doe",50000.00);

            Console.WriteLine("Display current employee information: ");
            employee1.DisplayEmployeeDetails();

            Console.WriteLine($"\nCurrect employeeID: { employee1.EmployeeID}");

            employee1.Fullname = "John Doe Williams";
            Console.WriteLine($"\nUpdated fullname: {employee1.Fullname}");

            employee1.salary= 60000.00;
            Console.WriteLine($"\nUpdated fullname: {employee1.salary}");
            Console.ReadLine();




        }
    }

}
