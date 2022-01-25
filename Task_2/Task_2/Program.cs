using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            double grade = 0, sum = 0;
            string ans;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Please enter your exam score");
                ans = Console.ReadLine();
                grade = Convert.ToDouble(ans);
                sum += grade;
            }

            double avg = ((sum / 3) / 100);
            Console.WriteLine($"The percentage you have is {avg.ToString("P")}");
        }
    }
}
