using MIS3033_Student;
using System;

namespace OOP_Student_Class_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Student mandarstu = new Student("Mandar", "Bornare", "11345679");
            string stuInfo = mandarstu.ToString();

            Console.WriteLine("Input a grade");
            double g = Convert.ToDouble(Console.ReadLine());
            double weight = 150.6;
            string message = weight.ToString();
             char lg = mandarstu.Getdoublegrade(g);
            Console.WriteLine(lg);
        }
    }
}
