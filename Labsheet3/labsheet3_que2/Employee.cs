using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet3_que2
{
    public class Employee
    {
        private int employeeID;   
        private string fullname;
        public double salary;

        public Employee(int _employeeId , string _fullname , double _salary)
        {
            employeeID = _employeeId;
            Fullname = _fullname;
            salary = _salary;
            
        }

        public int EmployeeID => employeeID;//read only property

        public string Fullname
        {
            get => fullname;
            set => fullname = value;

        }

        

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Employee Fullname: {fullname}");
            Console.WriteLine($"Employee salary: {salary}");
        }
    }


}
