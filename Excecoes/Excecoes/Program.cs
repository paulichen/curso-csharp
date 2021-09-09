using System;
using Excecoes.Entities;
using Excecoes.Entities.Exceptions;

namespace Excecoes {
    class Program {
        static void Main(string[] args) {

            try {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Update reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine("Updated reservation: " + reservation);
            } catch(DomainException e) {
                Console.WriteLine("Error in reservation: " + e.Message);
            } catch(FormatException e) {
                Console.WriteLine("Format Error: " + e.Message);
            } catch(Exception e) {
                Console.WriteLine("Unexpected Error: " + e.Message);
            }

        }
    }
}
