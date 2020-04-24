using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_I_Futbollit.BO
{
    public class LojtaretENdeshjes
    {
        public int NdeshjaID { get; set; }

        public Klubi KlubiID { get; set; }

        public Lojtari LojtariID { get; set; }

        public string Pozita { get; set; }

        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public int LUB { get; set; }
        public int LUN { get; set; }
        public DateTime LUD { get; set; }
    }
}
