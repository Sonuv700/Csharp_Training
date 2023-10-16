using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionCalculator
{
    public class ConcessionCalculator
    {
            private const double BaseFare = 500.0;

            public void CalculateConcession(int age, string name)
            {
                if (age <= 5)
                {
                    Console.WriteLine($"{name} - Little Champs - Free Ticket (Age: {age})");
                }
                else if (age > 60)
                {
                    double concessionAmount = 0.3 * BaseFare;
                    double discountedFare = BaseFare - concessionAmount;
                    Console.WriteLine($"Senior Citizen ({name}, Age: {age}) - Discounted Fare: {discountedFare:C}");
                }
                else
                {
                    Console.WriteLine($"Ticket Booked ({name}, Age: {age}) - Fare: {BaseFare:C}");
                }
            }
        }
    }

