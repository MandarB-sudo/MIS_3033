using System;

namespace Mandar_Bornare_HW1.zip
{
    class Program
    {
        const double whole_sale_cogs_price = 79.99;
        const int whole_sale_gears_price = 250;
        const double normalmarkup = 0.15;
        const double discount_markup = 0.12;
        const double sales_tax = 0.089;
        static void Main(string[] args)
        {
            
            int cogs_quantity , gears_quanitity;
            double sales_total, tax, discount,Total;
            Console.WriteLine("Please input the number of Cogs you would like to buy");
            string ans1 = Console.ReadLine();
            cogs_quantity = Convert.ToInt32(ans1);
            Console.WriteLine("Please input the number of Gears you would like to buy");
            string ans2= Console.ReadLine();
            gears_quanitity = Convert.ToInt32(ans2);



        }
    }
}
