using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Customer
    {

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public byte Cinsiyet { get; set; }
        public string TcKimlikNo { get; set; }
        public string Meslek { get; set; }
        public List<BankAccount> Hesaplar { get; set; }

        public Customer()
        {
            Hesaplar = new List<BankAccount>();
        }

    }
}
