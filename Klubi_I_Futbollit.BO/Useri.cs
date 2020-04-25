using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_I_Futbollit.BO
{
  public  class Useri
    {
        public int UserID { get; set; }
        public bool IsActive { get; set; }
        public string EmriIPerdoruesit { get; set; }
        public string PasswordiPerdoruesit { get; set; }
        public DateTime DataSkadimit { get; set; }
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public int LUB { get; set; }
        public int LUN { get; set; }
        public DateTime LUD { get; set; }
    }
}
