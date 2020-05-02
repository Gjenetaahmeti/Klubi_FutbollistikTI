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
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string EmriIPerdoruesit { get; set; }
        public string Fjalkalimi { get; set; }
        public int NumriFanelles { get; set; }
        public string Gjinia { get; set; }
        public DateTime Ditelindja { get; set; }
        public string Vendlindja { get; set; }
        public string GrupiGjakut { get; set; }
        public string Shteti { get; set; }
        public string Vendbanimi { get; set; }
        public string Telefoni { get; set; }
        public string Mail { get; set; }
        public decimal Pesha { get; set; }
        public decimal Gjatesia { get; set; }

        public Klubi KlubiID { get; set; }
        public Role RoliID { get; set; }
    }
}
