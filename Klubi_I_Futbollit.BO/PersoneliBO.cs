using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_Futbollistik.BO
{
    public class PersoneliBO
    {
        public int ID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Specializimi { get; set; }
        public string Titulli { get; set; }
        public string VendiIPunes { get; set; }
        public Boolean Gjinia { get; set; }
        public DateTime Ditelindja { get; set; }
        public string Vendlindja { get; set; }
        public string GrupiIGjakut { get; set; }
        public string Shteti { get; set; }
        public string Vendbanimi { get; set; }
        public string Telefoni { get; set; }
        public string Mail { get; set; }
        public string AnetaretEGrupit { get; set; }
        public string NderrimiIPunes { get; set; }
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public int LUB { get; set; }
        public int LUN { get; set; }
        public DateTime LUD { get; set; }
    }
}
