using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimNedir
{
   public class Egitmen:temelTip
    {
        public string Brans { get; set; }
        public int BransSeviye { get; set; }

        public Egitmen()
        {
            Console.WriteLine("Eğitmen nesnesinin yapıcı metotu çalıştı.");
           // IdAtamaIslemi
        }
    }
}
