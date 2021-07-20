using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
    class UC_2DaysOfWeek
    {
        public void days()
        {
            int m, d, y;
            Console.WriteLine("enter the month: 1 to 12");
             m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the year:four digits");
             y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the day : 1 to 31");
             d = Convert.ToInt32(Console.ReadLine());

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;

            int d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine("Date: {0}-{1}-{2}", d, m, y);

            String[] month = { "January", "febraury","March","April","May","June","July","August","September","October","November","December" };
            string[] day = { "Sunday", "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday" };

            Console.WriteLine("Day is:" + day[d]);  
            Console.WriteLine("Month is:" + month[m]);
            Console.WriteLine("Year is:" + y);
           


        }
    }
    }

