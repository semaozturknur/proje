using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucusyap
{
    internal class reeervasyon
    {

        public Ucak Ucak { get; set; }  
        public lokasyon lokasyon { get; set; } 
        public müsteri Müsteri { get; set; }
        public DateTime reztarihi;
        public int koltukno;


        public void reztarihbilgisi()
        {
            

        }

        public void koltuknobilgisi()
        {
            Console.WriteLine("Koltuk No'nuz:" + koltukno);

        }



    }
}
