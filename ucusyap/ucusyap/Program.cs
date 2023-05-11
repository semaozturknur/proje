using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucusyap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen adınızı giriniz");
            Console.ReadKey();
            müsteri isim = new müsteri ();
            isim.ad = Console.ReadLine();   
            
            Console.ReadKey (); 

            Console.WriteLine("Lütfen soyadınızı giriniz");
            Console.ReadKey();
            müsteri soyisim = new müsteri();
            isim.soyad = Console.ReadLine ();   
          
            Console.ReadKey();

            Console.WriteLine("Lütfen yaşınızı giriniz");
            Console.ReadKey();
            müsteri yasiniz = new müsteri();
            yasiniz.yas = int.Parse(Console.ReadLine());
         
            Console.ReadKey();

            Console.Write("Cinsiyetinizi girin (erkek/kadın): ");
            Console.ReadKey();
            müsteri cinsiyeti = new müsteri();
            cinsiyeti.cinsiyet = Console.ReadLine();
            if (cinsiyeti.cinsiyet == "erkek")
            {
                Console.WriteLine("Erkek seçildi.");
            }
            else if (cinsiyeti.cinsiyet == "kadın")
            {
                Console.WriteLine("Kadın seçildi.");
            }
            else
            {
                Console.WriteLine("Geçersiz seçim.");
            }

            Console.ReadLine();


            Console.WriteLine("Lokasyon için ülkeyi belirtiniz");
            Console.ReadKey();
            lokasyon ulkeadi = new lokasyon ();
            ulkeadi.ulke = Console.ReadLine (); 
         
            Console.ReadKey();

            Console.WriteLine(ulkeadi.ulke +"içerisinde gitmek istediğiniz şehri belirtiniz.");
            Console.ReadKey();
            lokasyon sehiradi = new lokasyon();
            sehiradi.sehir = Console.ReadLine ();   
            Console.ReadKey();

            Console.WriteLine("Lütfen istediğiniz tarih ve saati yazınız:");
            Console.ReadKey();
            reeervasyon tarihsaat = new reeervasyon();
            tarihsaat.reztarihi = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(tarihsaat);

            Console.ReadLine();
            Console.WriteLine("Koltuk no giriniz. ");
            Console.ReadKey();  
            reeervasyon koltuknomuz= new reeervasyon();
            koltuknomuz.koltukno = int.Parse(Console.ReadLine ());
            Console.ReadKey ();

            Console.WriteLine(isim.ad ,soyisim.soyad +"adına " + tarihsaat.reztarihi+"tarihinde " + ulkeadi.ulke + "adlı ülkeye"+ sehiradi.sehir + " 'a" + 
                "rezervasyonunuz yapılmıştır. Keyifli uçuşlar dileriz. ");

            Console.ReadLine(); 






        }
    }
}
