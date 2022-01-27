using System;
using System.Collections.Generic;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            string ans;
            double grade , avg, sum = 0;
            do
            {

            
            Console.WriteLine("Please enter your exam score ");
                ans = Console.ReadLine();
                grade = Convert.ToDouble(ans);
                grades.Add(grade);

                Console.WriteLine("Would you like to enter another score ?");
                ans = Console.ReadLine();
            } while (ans.ToUpper() == "YES");

            for (int i = 0; i < grades.Count; i++)
            {
                sum+= grades[i];
            }
            avg = sum / grades.Count;
             
            Console.WriteLine(avg);
        }
    }
}
