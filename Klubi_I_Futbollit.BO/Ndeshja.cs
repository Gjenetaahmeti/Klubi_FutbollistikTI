using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_I_Futbollit.BO
{
    public class Ndeshja
    {
        public int NdeshjaID { get; set; }
        public DateTime dataNdeshjes { get; set; }
        public DateTime Vitikalendarik { get; set; }
        public string Sezoni { get; set; }
        public Klubi KlubiID { get; set; }
        public Formacioni FormacioniID { get; set; }

        public string Stadiumi { get; set; }

        public string RaportiAmbulances { get; set; }

        public string RaportiPolicor { get; set; }

        public string KlubiNikoqir { get; set; }
        public string KlubiMysafir { get; set; }

        public Liga LigaID { get; set; }
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public int LUB { get; set; }
        public int LUN { get; set; }
        public DateTime LUD { get; set; }
    }
}
