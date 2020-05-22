using System;
using ExcecaoPersonalizada.Entities;
using ExcecaoPersonalizada.Entities.Exceptions;

namespace ExcecaoPersonalizada
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                System.Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                System.Console.WriteLine("Reservation: " + reservation);

                System.Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");                
                System.Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());
            
                reservation.UpdateDates(checkIn, checkOut);
                System.Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                System.Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                System.Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
