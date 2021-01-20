using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            BankAccount account;
            CustomerManager customerManager = new CustomerManager();
            while (! exit)
            {
                Console.WriteLine("İşlem seçiniz 1: müşteri ekle, 2:hesap ekle, 3:listele, 4:kredi al, 5:hesap sil, 6:müşteri sil, 0: çıkış");

                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {

                        case 1:

                            Console.WriteLine("Müşteri adı giriniz");
                            string ad = Console.ReadLine();
                            Console.WriteLine("Müşteri soyadı giriniz");
                            string soyad = Console.ReadLine();
                            Console.WriteLine("Müşteri yaşı giriniz");
                            int yas = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Müşteri cinsiyet giriniz 1 erkek 2 kadın");
                            byte cinsiyet = Convert.ToByte(Console.ReadLine());
                            Console.WriteLine("Müşteri tc kimlik no giriniz");
                            string tc = Console.ReadLine();
                            Console.WriteLine("Müşteri mesleği giriniz");
                            string meslek = Console.ReadLine();
                            

                            Customer customer = new Customer
                            {
                                Ad = ad,
                                Soyad = soyad,
                                Yas = yas,
                                Cinsiyet = cinsiyet,
                                TcKimlikNo = tc,
                                Meslek = meslek,
                            };

                            customerManager.AddCustomer(customer);

                            break;
                        case 2:

                            Console.WriteLine("Kredi limiti giriniz");
                            int kredilimit = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Müşteri tc no");
                            string findtc = Console.ReadLine();

                            account = new BankAccount
                            {


                                KrediLimit = kredilimit,

                                Musteri = customerManager.FindCustomer(findtc)

                            };

                            customerManager.AddBankAccount(customerManager.FindCustomer(findtc), account);

                            break;

                        case 3:

                            customerManager.List();

                            break;
                        case 4:

                            Console.WriteLine("Müşteri tc no");
                            string findtccredit = Console.ReadLine();
                            Console.WriteLine("kredi miktarı");
                            int kredimiktari = Convert.ToInt32(Console.ReadLine());

                            customerManager.TakeCredit(customerManager.FindCustomer(findtccredit), kredimiktari);

                            break;
                        case 5:

                            Console.WriteLine("Müşteri tc no");
                            string findtcbank = Console.ReadLine();
                            Console.WriteLine("hesap no");
                            long hesapno = Convert.ToInt64(Console.ReadLine());

                            customerManager.DeleteBankAccount(customerManager.FindBankAccount(customerManager.FindCustomer(findtcbank), hesapno));

                            break;
                        case 6:

                            Console.WriteLine("Müşteri tc no");
                            string findtccustomer = Console.ReadLine();

                            customerManager.DeleteCustomer(customerManager.FindCustomer(findtccustomer));

                            break;

                        case 0:
                            exit = true;
                            break;

                        default:

                            Console.WriteLine("lütfen geçerli bir işlem seçiniz");

                            break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    
                }
                
            }
            




            

        }

    }
}

