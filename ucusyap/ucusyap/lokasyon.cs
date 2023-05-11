using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ucusyap
{
    internal class lokasyon
    {
        // nesneler
        public string ulke;
        public string sehir;
        public string havaalani;
        

        //metotlar

        public void Ulkebilgisi()
        {
            Console.WriteLine("Seçtiğiniz ulke" + ulke + "dir");
        }
        public void Sehirbilgisi()
        {
            Console.WriteLine("Seçtiğiniz şehir " + sehir + "dir");
        }
        public void Modelbilgisi()
        {
            Console.WriteLine("Tercih ettiğiniz havaalani" + havaalani + "dir");
        }
        
    }
}
