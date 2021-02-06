﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2020_07_06.ViewModels
{
    public class DodajUcesnikaVM
    {
        public List<SelectListItem> Ucesnik { get; set; }
        public int UcesnikID { get; set; }
        public int Bodovi { get; set; }
        public int TakmicenjeID { get; set; }
    }
}
