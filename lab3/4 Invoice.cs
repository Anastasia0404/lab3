using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Invoice
    {
        public readonly int account;
        public readonly string provider;
        public readonly string customer;
        private string article;
        private int quantity;
        public Invoice(int account, string provider, string customer)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public string Article
        {
            set
            {
                article = value;
            }
        }
        public int Quantity
        {
            set
            {
                quantity = value;
            }
        }
        public void PricewithTax()
        {
            Console.WriteLine($"Цiна товару з ПДВ становить: {account * quantity}");
        }
        public void PricewithoutTax()
        {
            Console.WriteLine($"Цiна товару без ПДВ становить: {account * quantity * 0.8}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string tempProvider, tempCustomer;
            int tempAccount;
            Console.Write("Введiть account: ");
            tempAccount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть provider: ");
            tempProvider = Console.ReadLine();
            Console.Write("Введiть customer: ");
            tempCustomer = Console.ReadLine();
            Invoice invoice = new Invoice(tempAccount, tempProvider, tempCustomer);
            Console.Write("Введiть article: ");
            invoice.Article = Console.ReadLine();
            Console.Write("Введiть quantity: ");
            invoice.Quantity = Convert.ToInt32(Console.ReadLine());
            invoice.PricewithTax();
            invoice.PricewithoutTax();
            Console.WriteLine("Нажмiть будь-яку клавiшу для завершення програми");
            Console.ReadKey();
        }
    }
}
