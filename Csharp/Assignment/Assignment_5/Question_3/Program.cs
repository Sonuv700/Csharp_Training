using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
   internal class Saledetails
    {
        private int SalesNo;
        private int ProductNo;
        private double Price;
        private DateTime DateOfSale;
        private int Qty;
        private double TotalAmount;


        public Saledetails(int salesNo, int productNo, double price, int qty, DateTime dateOfSale)
        {
            this.SalesNo = salesNo;
            this.ProductNo = productNo;
            this.Price = price;
            this.Qty = qty;
            this.DateOfSale = dateOfSale;
            this.TotalAmount = CalculateTotalAmount();
        }
        private double CalculateTotalAmount()
        {
            return Qty * Price;
        }
        public void ShowData()
        {
            Console.WriteLine("Sales No: " + SalesNo);
            Console.WriteLine("Product No: " + ProductNo);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Date of Sale: " + DateOfSale);
            Console.WriteLine("Qty: " + Qty);
            Console.WriteLine("Total Amount: " + TotalAmount);
            Console.ReadLine();
        }

        static void Main()
        {
            Saledetails sale = new Saledetails(07, 11332815, 120, 5, DateTime.Now);
            sale.ShowData();
        }
    }
}
