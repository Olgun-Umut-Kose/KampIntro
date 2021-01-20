using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class BankAccount
    {

        
        
        public long HesapNo { get; set; }
        public string IBAN { get; private set; }
        public int KrediLimit { get; set; }
        public int Kredi { get; set; }
        public Customer Musteri { get; set; }

        public BankAccount()
        {
            KrediLimit = 150000;
            Kredi = 0;
            IBAN = "IBAN";
        }


    }
}
