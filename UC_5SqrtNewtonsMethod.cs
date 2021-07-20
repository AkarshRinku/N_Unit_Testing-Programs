using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
    class UC_5SqrtNewtonsMethod
    {
        public void  Sqrt()
        {
            Console.WriteLine("Welcome to Newton's method:");
            Console.WriteLine("Enter the value of c :");
            double c = Convert.ToDouble(Console.ReadLine());

            double epsilon = 1e-15;
            double t = c;

            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }

            Console.WriteLine(t);
        }
    }
}
