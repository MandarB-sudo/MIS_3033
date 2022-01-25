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

            int cogs_quantity, gears_quanitity, Totalquantity = 0 ;
            double sales_total, sales_markup, tax, discount,Total;
            Console.WriteLine("Please input the number of Cogs you would like to buy");
            string ans1 = Console.ReadLine();
            cogs_quantity = Convert.ToInt32(ans1);
            Console.WriteLine("Please input the number of Gears you would like to buy");
            string ans2= Console.ReadLine();
            gears_quanitity = Convert.ToInt32(ans2);

            Totalquantity = cogs_quantity + gears_quanitity;

            if (Totalquantity < 16 && cogs_quantity <= 10 && gears_quanitity <= 10)
            {
                sales_total = (cogs_quantity * whole_sale_cogs_price) + ((cogs_quantity * whole_sale_cogs_price) * normalmarkup) + (gears_quanitity * whole_sale_gears_price)
                    + ((gears_quanitity * whole_sale_gears_price) * normalmarkup);

            }
            else if (Totalquantity < 16 && cogs_quantity > 10 && gears_quanitity <= 10)
            {
                sales_total = (cogs_quantity * whole_sale_cogs_price) + ((cogs_quantity * whole_sale_cogs_price) * discount_markup) + (gears_quanitity * whole_sale_gears_price)
                    + ((gears_quanitity * whole_sale_gears_price) * normalmarkup);
            }
            else if (Totalquantity < 16 && cogs_quantity <=10 && gears_quanitity >10)
            {
                sales_total = (cogs_quantity * whole_sale_cogs_price) + ((cogs_quantity * whole_sale_cogs_price) * normalmarkup) + (gears_quanitity * whole_sale_gears_price)
                    + ((gears_quanitity * whole_sale_gears_price) * discount_markup);
            }

        }
    }
}
