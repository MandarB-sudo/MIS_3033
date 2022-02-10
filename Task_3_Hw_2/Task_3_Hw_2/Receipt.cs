using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Hw_2
{
    class Receipt
    {
        public int CustomerID { get; set; }
        public int CogQuantity { get; set; }
        public int GearQuantity { get; set; }
        public DateTime SaleDate { get; set; }
        private double SalesTaxPercent { get; set; }
        private double CogPrice { get; set; }
        private double GearPrice { get; set; }

        public Receipt()
        {
            CustomerID = 0;
            CogQuantity = 0;
            GearQuantity = 0;
            SaleDate = DateTime.Now;
            SalesTaxPercent = 0.089;
            CogPrice = 79.9;
            GearPrice = 250;
        }
        public Receipt(int id , int cog,int gear)
        {
            CustomerID= id;
            CogQuantity = cog;
            GearQuantity = gear;
        }

       
        public double CalculateTotal ()
        {
            double Total;
            Total = CalculateNetAmount() + CalculateTaxAmount();
            return Total;
        }
        
        private double CalculateTaxAmount()
        {
            double SalesTaxTotal;
            SalesTaxTotal = CalculateNetAmount() * SalesTaxPercent;
            return SalesTaxTotal;
        }
        private double CalculateNetAmount()
        {
            const double standardmarkup = 0.15;
            const double discountmarkup = 0.125;
 
            int TotalQuantity = CogQuantity + GearQuantity;
            double netamount;
            if (CogQuantity > 10 || GearQuantity >10 || TotalQuantity >=16 )
            {
                netamount = CogQuantity * (CogPrice + discountmarkup * CogPrice) + GearQuantity * (GearPrice + discountmarkup * GearPrice);
                return netamount;
            }
            else
            {
                netamount = CogQuantity * (CogPrice + standardmarkup * CogPrice) + GearQuantity * (GearPrice + standardmarkup * GearPrice);
                return netamount;
            }

            
            
        }
         public void PrintReceipt()
        {
            string message = $"Customer ID: {CustomerID} \nThe no. of Cogs: {CogQuantity} \nThe no. of Gears: {GearQuantity} \nThe Price of the order is: {CalculateNetAmount().ToString("C")} \n" +
                $"The Tax applied is: {CalculateTaxAmount().ToString("C")} \nThe Total price is: {CalculateTotal().ToString("C")} \nTime:{SaleDate}";
            Console.WriteLine(message);
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }

}
