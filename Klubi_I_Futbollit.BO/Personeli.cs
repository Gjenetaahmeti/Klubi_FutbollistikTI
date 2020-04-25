using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_I_Futbollit.BO
{
 public  class Personeli
    {
        public Personeli() { }
        //Shto Personel
        public Personeli(int iD, string emri, string mbiemri, string specializimi, string titulli, string vendiIPunes, bool gjinia, DateTime ditelindja, string vendlindja, string grupiIGjakut, string shteti, string vendbanimi, string telefoni, string mail, string anetaretEGrupit, string nderrimiIPunes, int insertBy, DateTime insertDate, int lUB, int lUN, DateTime lUD)
        {
            ID = iD;
            Emri = emri;
            Mbiemri = mbiemri;
            Specializimi = specializimi;
            Titulli = titulli;
            VendiIPunes = vendiIPunes;
            Gjinia = gjinia;
            Ditelindja = ditelindja;
            Vendlindja = vendlindja;
            GrupiIGjakut = grupiIGjakut;
            Shteti = shteti;
            Vendbanimi = vendbanimi;
            Telefoni = telefoni;
            Mail = mail;
            AnetaretEGrupit = anetaretEGrupit;
            NderrimiIPunes = nderrimiIPunes;
            InsertBy = insertBy;
            InsertDate = insertDate;
            LUB = lUB;
            LUN = lUN;
            LUD = lUD;
        }

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
