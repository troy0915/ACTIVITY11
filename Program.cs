using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity11pin_code_retry_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string correctPin = "1234";
            int maxAttempts = 3;

            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                Console.Write("Enter your 4-digit PIN: ");
                string enteredPin = Console.ReadLine();

                // Check if the entered PIN is correct
                if (enteredPin == correctPin)
                {
                    Console.WriteLine("Access granted.");
                    return; // Exit the program if access is granted
                }
                else
                {
                    Console.WriteLine("Incorrect PIN. Please try again.");
                }
                // Check if attempts are exhausted
                if (attempt == maxAttempts)
                {
                    Console.WriteLine("Access denied.");
                }
            }
        }
    }
}
      




