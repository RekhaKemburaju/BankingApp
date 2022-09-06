using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Bank
{
    public class BusinessCustomer :Customer
    {
        private String ABN;

        public BusinessCustomer(string name,string address ,string ABN):base(name,address)
        {
            this.ABN = ABN;
        }
         public String _ABN
        {
            get { return ABN; }
            set { ABN = value; }
        }
        public void showBusinessCustomerDetails()
        {
            Console.WriteLine("Customer Name: " + base.CustName);
            Console.WriteLine("Customer Address: " + base.CustAddress);
            Console.WriteLine("ABN: " + ABN);

        }


    }
}
