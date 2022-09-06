using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Bank
{
    public class PersonalCustomer:Customer
    {
        private string TFN;
        private DateTime DOB;

        public PersonalCustomer(string name,string address, string tfn, DateTime dOB):base (name, address)
        {
            this.TFN = tfn;
            DOB = dOB;
          
        }
        public string _TFN
        {
            get => TFN;
            set => TFN = value;
        }
        public DateTime getDOB()
        {
            return DOB;
        }
        public void setDOB(String dateString)
        {
            DOB = DateTime.Now;
        }
        public void showBusinessCustomerDetails()
        {
            Console.WriteLine("Customer Name: " + base.CustName);
            Console.WriteLine("Customer Address: " + base.CustAddress);
            Console.WriteLine("ABN: " + TFN);
            Console.WriteLine("DOB :" + DOB);

        }

    }
}
