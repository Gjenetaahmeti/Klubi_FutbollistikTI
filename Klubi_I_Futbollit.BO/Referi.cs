using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_I_Futbollit.BO
{
    public class Referi
    {
        public int ReferiID { get; set; }
        public Ndeshja NdeshjaID {get;set;}
        public PozitaReferit pozitaReferit {get;set;}
        public Personeli PersoniID { get; set; }
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public int LUB { get; set; }
        public int LUN { get; set; }
        public DateTime LUD { get; set; }
    }

}
