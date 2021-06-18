using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppCA
{
  public class BankAccountNew
    {
        //Constructor
        //public BankAccount
        //{
        //    Random rand = new Random();
        //}

        public string GenerateAccountNumber()
        {
            //
            Random rand = new Random();
            //int AcccountNo = rand.Next(1500, 1800);
            //string AccoutNumber = "NIBL-" + AcccountNo.ToString();
            string AccountNumber = "NIBL-" + rand.Next(1500, 1800);
            return AccountNumber;
        }

    }
}
