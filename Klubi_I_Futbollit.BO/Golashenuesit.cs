﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_I_Futbollit.BO
{
    public class Golashenuesit
    {
        public int GolashenuesiID { get; set; }
        public static Lojtari LojtariID { get; set; }
        public int NumriGolave { get; set; }
        public static Ndeshja NdeshjaID { get; set; }

        public int lojtariID = Convert.ToInt32(LojtariID);
        public int ndeshjaID = Convert.ToInt32(NdeshjaID);
    }
}
