using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_I_Futbollit.BO
{
    public class Klubi
    {
        public int KlubiID { get; set; }
        public string Emertimi { get; set; }
        public string Vendi { get; set; }
        public string Stadiumi { get; set; }
        public string Kryetari { get; set; }

        public Liga ligaint {get;set;}
        public string Rezultati { get; set; }
        public DateTime Themeluar { get; set; }
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public int LUB { get; set; }
        public int LUN { get; set; }
        public DateTime LUD { get; set; }
    }
}
