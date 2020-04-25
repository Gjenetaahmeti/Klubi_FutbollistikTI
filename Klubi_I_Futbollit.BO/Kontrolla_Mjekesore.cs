using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_I_Futbollit.BO
{
   public class Kontrolla_Mjekesore
    {
        public int KontrollaMjekesoreID { get; set; }
        public Personeli PersoniID { get; set; }
        public DateTime KontrollaData { get; set; }
        public string Kontrolla { get; set; }
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public int LUB { get; set; }
        public int LUN { get; set; }
        public DateTime LUD { get; set; }

    }
}
