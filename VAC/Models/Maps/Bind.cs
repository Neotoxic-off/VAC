﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Maps
{
    public class Bind : IMap
    {
        public string Name { get; set; } = "Bind";
        public string Splash { get; set; } = "/Assets/Maps/Bind.avif";
    }
}
