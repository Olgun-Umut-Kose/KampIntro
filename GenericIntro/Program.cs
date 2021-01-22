using System;
using System.Collections.Generic;

namespace GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList();

            

            MyDictionary<string, int> dictionary = new MyDictionary<string, int>();
            dictionary.Add("Anahtar1", 10);
            dictionary.Add("Anahtar2", 30);
            Console.WriteLine(dictionary["Anahtar1"]);//parametreli prop nasıl kullanılır : )
            Console.WriteLine(dictionary["Anahtar2"]);
            Console.WriteLine(dictionary[10]);
            Console.WriteLine(dictionary[30]);

        }

        private static void MyList()
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("BERKAY"); // : )

            Console.WriteLine("Hello World!");
        }
    }
}
