using System;
using System.Globalization;
using LocadoraVeiculos.Entities;
using LocadoraVeiculos.Services;

namespace LocadoraVeiculos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter rental data: ");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime pickup = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            CarRental cr = new CarRental(pickup, finish, new Vehicle(model));
            RentalService rs = new RentalService(hour, day, new BrazilTaxService());

            rs.ProcessInvoice(cr);

            Console.WriteLine("Invoice: ");
            Console.WriteLine(cr.Invoice);

        }
    }
}
