﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_I_Futbollit.BO
{
    public class Klubi
    {
        public int KlubiID { get; set; }
        public string Emertimi { get; set; }
        public string Vendi { get; set; }
        public string Kryetari { get; set; }

        public DateTime IThemeluar { get; set; }

        public Stadiumi StadiumiID { get; set; }

        public Liga LigaID { get; set; }
    }
}
