using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_I_Futbollit.BO
{
   public class Lojtari
    {
        public int LojtariID { get; set; }
        public Personeli PersoneliId { get; set; }
        public decimal Pesha { get; set; }
        public decimal Gjatesia { get; set; }
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public int LUB { get; set; }
        public int LUN { get; set; }
        public DateTime LUD { get; set; }
    }
}
