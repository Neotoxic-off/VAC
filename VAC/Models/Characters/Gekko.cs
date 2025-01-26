﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Gekko : ICharacter
    {
        public string Name { get; set; } = "Gekko";
        public string Splash { get; set; } = "/Assets/Characters/Gekko.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Initiator;
    }
}

