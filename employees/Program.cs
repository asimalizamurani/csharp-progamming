using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_oop
{

    class Employees
    {
        int id;
        string name, email;

        public void employeeDetails(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }

        public void printDetails()
        {
            Console.WriteLine($"Hello Mr {this.name}");
            Console.WriteLine($"Your employee id is: {this.id}");
            Console.WriteLine($"And your email is {this.email}");
        }
    }

        internal class Program
        {
            static void Main(string[] args)
            {

            Employees employee = new Employees();
            employee.employeeDetails(1, "Asim", "asim@gmail.com");
            employee.printDetails();

            employee.employeeDetails(2, "Mohsin", "mohsin@gmail.com");
            employee.printDetails();

            employee.employeeDetails(3, "Ali", "ali@gmail.com");
            employee.printDetails();

            }
        }
    }

