using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice_1 = new Invoice(1111, "he", "I");
            invoice_1.Article = "4";
            invoice_1.Quantity = 2;
            Console.WriteLine($"For payment: {invoice_1.billWithVAT():F2}");
            Console.WriteLine($"             { invoice_1.billWithoutVAT():F2} (+VAT)");
        }
    }
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;

        string article;
        int quantity;

        public string Article { set { article = value; } }
        public int Quantity { set { quantity = value; } }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

    
        public double billWithoutVAT()
        {
           double bill = 0.0;
            switch (article)
            {
                case "1": bill = 50.0f;
                    break;
                case "2":
                    bill = 40.0f;
                    break;
                case "3":
                    bill = 30.0f;
                    break;
                case "4":
                    bill = 3.5f;
                    break;
            }
            return bill * quantity;
        }
        public double billWithVAT()
        {
            return billWithoutVAT() * 1.18f;
        }
    }
}
