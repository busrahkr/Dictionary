using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //LİSTELENECEK OLAN VERİLER(bu arada,belirtilen key yani int,string kalıbı oluşturulduktan sonra value yani değer girilir)
            Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
            ogrenciler.Add(1," Ayşe");
            ogrenciler.Add(2, " Emel");
            ogrenciler.Add(3, " Ali");
            ogrenciler.Add(4, " Kayra");
            ogrenciler.Add(5, " Büşra");

            Console.WriteLine(ogrenciler.Count);
          

        }
    }
}
