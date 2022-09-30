using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynInit
{
    class Program
    {
        static void Main(string[] args)
        {
            int yıl, ay, gun;
            don:
            Console.WriteLine("kaç yaşındasınız");
            Console.Write("Dogum yılınız: ");
            yıl = Convert.ToInt32(Console.ReadLine());
             if (2018 < yıl) 
            {
                Console.WriteLine("Hata var!");
                goto don;
            }
          don1:
            Console.Write("ay: ");
            ay = Convert.ToInt32(Console.ReadLine());
            if (12 < ay)
            {
                Console.WriteLine("Hata var!");
                Console.WriteLine("AY'I BÜYÜK GİRDİNİZ!" +
                    "1-12");
                goto don1;
            }
            don2:
            Console.Write("gun: ");
            gun = Convert.ToInt32(Console.ReadLine());

            if (31 < gun)
            {
                Console.WriteLine("Hata var!");
                goto don2;
            }
            DateTime dogumTarhi = new DateTime(yıl, ay, gun);
            int extragun = (DateTime.Today.Year - dogumTarhi.Year) / 4;
            int sonuc = (DateTime.Today.Year - dogumTarhi.Year);
            int sonuc1 = (sonuc * 365);
            int sonuc2 = (sonuc1 * 24);
            int sonuc3 = (sonuc * 52);
            if (ay > DateTime.Today.Month)
                sonuc = sonuc - 1;
            int yay = (DateTime.Today.Month - ay);
            if (gun > DateTime.Today.Day) ;
            int ggun = (DateTime.Today.Day - gun);


            Console.WriteLine(ggun + " gun");
            Console.WriteLine(yay + " ay");
            Console.WriteLine("Yaşınız: " + sonuc);
            Console.WriteLine("Yaşadığınız gün: " + sonuc1);
            Console.WriteLine("Yaşadığınız saat: "+ sonuc2);
            Console.WriteLine("Yaşadığınız hafta: "+sonuc3);
            Console.WriteLine("nice yıllar");


            Console.ReadKey();
        }
    }
}
