// Directive namespaces

// enables dictionaries
using System.Collections.Generic;
using System;
// using System.IO;
// enables lists
// using System.Net;
// using System.Threading.Tasks;


namespace CatWorx.BadgeMaker
{
    class Program
    {

        static List<string> GetEmployees()
        {
            List<string> employees = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter a name: ");
                string input = Console.ReadLine() ?? "";

                if (input == "")
                {
                    break;
                }
                // Create a new Employee instance
                Employee currentEmployee = new Employee();
                employees.Add(input);
            }
            return employees;  

        }

        static void PrintEmployees(List<string> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }

        static void Main(string[] args)
        {
            List<string> employees = GetEmployees();

            for (int i = 0; i < employees.Count; i++) 
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
    
}