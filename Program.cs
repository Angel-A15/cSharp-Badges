// Directive namespaces

// enables dictionaries
using System.Collections.Generic;
using System;
// using System.Net;
using System.IO;
// enables lists
// using System.Net;
// using System.Threading.Tasks;


namespace CatWorx.BadgeMaker
{
    class Program
    {

        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                Console.WriteLine("Enter first name (leave empty to exit): ");
                
                string firstName = Console.ReadLine() ?? "";

                if (firstName == "")
                {
                    break;
                }

                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine() ?? "";
                Console.Write("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine() ?? "");
                Console.Write("Enter Photo URL:");
                string photoUrl = Console.ReadLine() ?? "";
                // Create a new Employee instance
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }
            return employees;  

        }


        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            
            // PrintEmployees(employees);
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);

            for (int i = 0; i < employees.Count; i++) 
            {
                Console.WriteLine(employees[i].GetFullName());
            }
        }
    }
    
}