using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_I_Futbollit.BO
{
    public class StatusiLojtarit
    {
        public int StatusiID { get; set; }

        public string Pergjegjes { get; set; }
        public string Rezerv { get; set; }
        public string Huazim { get; set; }
        public string Shoqerues { get; set; }

        public static Lojtari LojtariID { get; set; }
        public Formacioni FormacioniID { get; set; }

        public int Lojtariid = Convert.ToInt32(LojtariID);
        //public int InsertBy { get; set; }
        //public DateTime InsertDate { get; set; }
        //public int LUB { get; set; }
        //public int LUN { get; set; }
        //public DateTime LUD { get; set; }

    }
}
