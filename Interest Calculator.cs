using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Interest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Options");
            string[] option = {
                "1. Interest",
                "2. Principal",
                "3. Rate",
                "4. Time"
            };
            foreach (string i in option)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.Write("Please select an option : ");
            int user = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (user == 1)
            {
                Console.Write("Please enter the principal amount : ");
                double principal = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the rate in decimals : ");
                double rate = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the year : ");
                int time = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("The interest is ");
                Console.WriteLine(Interest(principal, rate, time));
            }
            else if (user == 2)
            {
                Console.Write("Please enter the interest : ");
                double interest = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the rate decimals : ");
                double rate = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the year : ");
                int time = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("The principal is ");
                Console.WriteLine(Principal(interest, rate, time));
            }
            else if (user == 3)
            {
                Console.Write("Please enter the interest : ");
                double interest = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the principal amount : ");
                double principal = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the year : ");
                int time = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("The rate is ");
                Console.WriteLine(Rate(interest, principal, time));
            }
            else if (user == 4)
            {
                Console.Write("Please enter the interest : ");
                double interest = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the principal amount : ");
                double principal = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the rate in decimals : ");
                double rate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("The time is ");
                Console.WriteLine(Time(interest, principal, rate));
            }
            else { Console.WriteLine("Invalid option"); }
        }

        static double Interest(double principal, double rate, int time)
        {
            return principal * rate * time;
        }
        static double Principal(double interest, double rate, int time)
        {
            return interest / (rate * time);
        }
        static  double Rate(double interest, double principal, int time)
        {
            return interest / (principal * time);
        }
        static int Time(double interest,double principal, double rate)
        {
            return (int)(interest / (principal * rate));
        }
    }
}
