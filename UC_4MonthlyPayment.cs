using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
    class UC_4MonthlyPayment
    {
        public void monthlypayment()
        {
            Console.WriteLine(" Welcome To Monthly Payment ");
            Console.WriteLine("Enter the duration of the loan (in years): ");
            double y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the princple amount: ");
            double p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the interest rate: ");
            double r = Convert.ToInt32(Console.ReadLine());

            r = r / 100;
           
            Console.WriteLine(" - Number of years .... {0}", y);
            Console.WriteLine(" - Principal amount ... {0:c}", p);
            Console.WriteLine(" - Interest rate ...... {0:p}", r);

            double monthlyRate = r/ 12;
            double payments = 12 * y;

            double result = (p * r) / (1 - Math.Pow((1 + r), (-1)));
           
            Console.WriteLine("Your monthly payment is:" + result);
            Console.ReadLine();

        }
    }
}
