﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_I_Futbollit.BO
{
   public class Formacioni
    {
        public int FormacioniID { get; set; }
        public Lojtari LojtariID { get; set; }
        public string Roli { get; set; }
        public int NrFanelles { get; set; }
        public StatusiLojtarit statusiLojtarit { get; set; }

        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public int LUB { get; set; }
        public int LUN { get; set; }
        public DateTime LUD { get; set; }
    }
}
