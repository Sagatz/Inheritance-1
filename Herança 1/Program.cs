using System;
using System.Collections.Generic;
using Herança_1.Entities;

namespace Herança_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char check = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (check == 'y' || check == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    Employee employee = new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge);

                    employees.Add(employee);
                }
                else if (check == 'n' || check == 'N')
                {
                    Employee employee = new Employee(name, hours, valuePerHour);

                    employees.Add(employee);
                }

            }
            Console.WriteLine("PAYMENTS:");

            foreach (Employee e in employees)
            {
                Console.WriteLine(e.Name + " - $ " + e.Payment().ToString("F2"));
            }
        }
    }
}
