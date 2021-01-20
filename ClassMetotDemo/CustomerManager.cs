using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        int id = 1;
        long hesapno = 1;
        


        public void AddCustomer(Customer customer)
        {
            customer.Id = id;
            customers.Add(customer);
            Console.WriteLine("--------------------Müşteri Veri Tabanına Eklendi------------------------");
            Console.WriteLine($"Müşteri ID: {customer.Id}");
            Console.WriteLine($"Müşterinin Adı: {customer.Ad}");
            Console.WriteLine($"Müşterinin Soyadı: {customer.Soyad}");
            Console.WriteLine($"Müşterinin Yaşı: {customer.Yas}");
            Console.WriteLine($"Müşterinin Mesleği: {customer.Meslek}");
            if (customer.Cinsiyet == 1)
            {
                Console.WriteLine("Müşterinin Cinsiyeti: Erkek");
            }
            else
            {
                Console.WriteLine("Müşterinin Cinsiyeti: Kadın");
            }
            Console.WriteLine($"Müşterinin Tc Kimlik Numarası: {customer.TcKimlikNo}");
            if (customer.Hesaplar.Count > 0)
            {
                Console.WriteLine("--------------------Müşterinin Hesapları------------------------");
                foreach (var item in customer.Hesaplar)
                {
                    Console.WriteLine($"Hesap No: {item.HesapNo}");
                    Console.WriteLine($"IBAN: {item.IBAN}");
                    Console.WriteLine($"Hesap Kredi Limit: {item.KrediLimit}");
                    Console.WriteLine($"Yıllık Çekilen Kredi: {item.Kredi}");
                    Console.WriteLine($"Hesap Sahibi: {item.Musteri.Ad} {item.Musteri.Soyad}");


                }
            }

            id++;


        }
        public void AddBankAccount(Customer customer, BankAccount account)
        {

            foreach (var item in customers)
            {
                if (item.TcKimlikNo == customer.TcKimlikNo)
                {
                    account.HesapNo = hesapno;
                    item.Hesaplar.Add(account);
                }
            }
            hesapno++;

        }

        

        public void List()
        {
            if (customers.Count > 0)
            {
                Console.WriteLine("--------------------Müşteri------------------------");
                foreach (var item in customers)
                {

                    Console.WriteLine($"Müşteri ID: {item.Id}");
                    Console.WriteLine($"Müşterinin Adı: {item.Ad}");
                    Console.WriteLine($"Müşterinin Soyadı: {item.Soyad}");
                    Console.WriteLine($"Müşterinin Yaşı: {item.Yas}");
                    Console.WriteLine($"Müşterinin Mesleği: {item.Meslek}");
                    if (item.Cinsiyet == 1)
                    {
                        Console.WriteLine("Müşterinin Cinsiyeti: Erkek");
                    }
                    else
                    {
                        Console.WriteLine("Müşterinin Cinsiyeti: Kadın");
                    }
                    Console.WriteLine($"Müşterinin Tc Kimlik Numarası: {item.TcKimlikNo}");

                    if (item.Hesaplar.Count > 0)
                    {
                        Console.WriteLine("--------------------Müşterinin Hesapları------------------------");
                        foreach (var itemAccount in item.Hesaplar)
                        {
                            Console.WriteLine($"Hesap No: {itemAccount.HesapNo}");
                            Console.WriteLine($"IBAN: {itemAccount.IBAN}");
                            Console.WriteLine($"Hesap Kredi Limit: {itemAccount.KrediLimit}");
                            Console.WriteLine($"Yıllık Çekilen Kredi: {itemAccount.Kredi}");
                            Console.WriteLine($"Hesap Sahibi: {itemAccount.Musteri.Ad} {itemAccount.Musteri.Soyad}");


                        }
                    }
                }
            }


        }


        public void DeleteCustomer(Customer customer)
        {
            for (int i = 0; i < customers.Count; i++)
            {

                if (customers[i].TcKimlikNo == customer.TcKimlikNo)
                {
                    customers[i].Hesaplar.Clear();
                    customers.Remove(customer);
                    Console.WriteLine("Kullanıcı başarı ile silindi");
                }

            }

        }

        public void DeleteBankAccount(BankAccount account)
        {

            foreach (var item in customers)
            {
                for (int i = 0; i < item.Hesaplar.Count; i++)
                {
                    if (item.Hesaplar[i].Musteri.TcKimlikNo == account.Musteri.TcKimlikNo)
                    {
                        item.Hesaplar.Remove(account);
                        Console.WriteLine("Hesap başarı ile silindi");
                    }
                }
            }
            

        }

        public void TakeCredit(Customer customer, int kredimiktari)
        {
            foreach (var item in customers)
            {
                for (int i = 0; i < item.Hesaplar.Count; i++)
                {
                    if (item.Hesaplar[i].KrediLimit > (item.Hesaplar[i].Kredi + kredimiktari))
                    {
                        item.Hesaplar[i].Kredi += kredimiktari;
                        Console.WriteLine("Krediniz hesabınıza tanımlandı");
                    }
                    else
                    {
                        Console.WriteLine("Yıllık Kredi Limitinizi Aşıyorsunuz Bu krediyi alamazsınız");
                    }
                }
            }
        }


        public Customer FindCustomer(string tc)
        {

            foreach (var item in customers)
            {
                if (item.TcKimlikNo == tc)
                {
                    return item;
                }
            }
            return new Customer();

        }

        public BankAccount FindBankAccount(Customer customer, long hesapno)
        {
            foreach (var item in customers)
            {
                if (item.TcKimlikNo == customer.TcKimlikNo)
                {
                    for (int i = 0; i < item.Hesaplar.Count; i++)
                    {
                        if (item.Hesaplar[i].HesapNo.Equals(hesapno))
                        {
                            return item.Hesaplar[i];
                            
                        }
                    }
                }
            }
            return new BankAccount();
        }



    }
}
