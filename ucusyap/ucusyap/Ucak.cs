using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucusyap
{
    internal class Ucak
    {
        // nesneler
        public string Model;
        public int SeriNo;
        public int BakimYili;
        public int mevcutsayi;


        // metotlar
        public void Modelbilgisi()
        {
            Console.WriteLine("Uçak Modeli " + Model + " dir");
        }

        public void SeriNobilgisi()
        {
            Console.WriteLine("Uçak Seri No " + SeriNo + " dir");
        }

        public void BakimYilibilgisi()
        {
            Console.WriteLine("Uçak bakımı " + BakimYili + " da yapılmıştır");
        }
        public void UcakMevcutbilgisi()
        {
            Console.WriteLine("Uçaktaki kişi sayısı " + mevcutsayi + " dir");
        }
    }

}
