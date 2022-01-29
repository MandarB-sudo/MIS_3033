using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please enter the value of slope");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of the intercept c for the line");
            double c = Convert.ToDouble(Console.ReadLine());
            LineValueforY(m, x, c);
            Console.WriteLine("Please enter the number you want to calculate the factorial of ");
            int n = Convert.ToInt32(Console.ReadLine());
            Factorial(n);


           

        }

        static double LineValueforY (double m , double x, double c)
        {
            double Y = 0;
              Y =  m * x + c;
            Console.WriteLine($"The Line Value for Y is {Y.ToString("N2")}");


            return Y;
        }
        static int Factorial (int n)
        {
            int res = 1;
            while (n !=1)
            {
                res = res * n;
                n = n - 1;

            }
            Console.WriteLine($"The factorial of the number is {res} ");
            return res;
        }
    }
}
