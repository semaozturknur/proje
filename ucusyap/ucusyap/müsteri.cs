using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucusyap
{
    internal class müsteri
    {
        public string ad;
        public string soyad;
        public int yas;
        public string engeldurumu ;
        public string cinsiyet ;


        public void adbilgisi()
        {
            Console.WriteLine("Adınız:  " + ad );
            
        }
        public void soyadbilgisi()
        {
            Console.WriteLine("Soyadınız:  " +  soyad);
           
        }
        public void yasbilgisi()
        {
            Console.WriteLine("Yaşınız:  " + yas);
        }

        
        public void engeldurumunuz()
        {

            if (engeldurumu == "1")
            {
                Console.WriteLine("Engelli durumunuz bulunmaktadır. ");
            }
            else if (engeldurumu == "2")
            {
                Console.WriteLine("Engel durumunuz bulunmamaktadır. ");
            }
        }

    }
}
