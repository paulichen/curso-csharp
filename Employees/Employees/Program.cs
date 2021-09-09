using System;
using System.Collections.Generic;
using Employees.Entities;
using System.Globalization;

namespace Employees {
    class Program {
        static void Main(string[] args) {

            List<Employee> employees = new List<Employee>();
            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {
                Console.WriteLine($"Employee #{i + 1} data: ");
                Console.Write("Outsourced? (y/n) ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'y') {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, addCharge));
                } else {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENT: ");
            foreach(Employee e in employees) {
                Console.WriteLine(e.Name + " - R$ " + e.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
