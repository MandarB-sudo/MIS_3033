using System;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Print the welcome messsage 
            /*
             This is our first class 
             
             */
            string name;

            

            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            string welcome =string.Format( $" Hi, {name},Welcome to MIS 3033");
            Console.WriteLine(welcome);
        }
    }
}
