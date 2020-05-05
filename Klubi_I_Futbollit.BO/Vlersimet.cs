using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_I_Futbollit.BO
{
    public class Vlersimet
    {
        public int  StatusiID { get; set; }
        public static Lojtari  LojtariID { get; set; }
        public decimal  Vlersimi { get; set; }
        public int InsertBY { get; set; }
        public DateTime InsertDate { get; set; }
        public int LUB { get; set; }
        public DateTime LUD { get; set; }
        public int LUN { get; set; }


        public int lojtariID = Convert.ToInt32(LojtariID);

    }
}
