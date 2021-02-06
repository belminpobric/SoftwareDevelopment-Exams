﻿using RS1_Ispit_asp.net_core.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2020_07_06.EntityModels
{
    public class TakmicenjeUcesnik
    {
        public int Id { get; set; }
        public virtual Takmicenje Takmicenje { get; set; }
        public int TakmicenjeID { get; set; }
        public virtual OdjeljenjeStavka OdjeljenjeStavka { get; set; }
        public int OdjeljenjeStavkaID { get; set; }
        public int Bodovi { get; set; }
        public bool IsPristupio { get; set; }
    }
}
