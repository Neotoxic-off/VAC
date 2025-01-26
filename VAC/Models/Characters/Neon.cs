using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Neon : ICharacter
    {
        public string Name { get; set; } = "Neon";
        public string Splash { get; set; } = "/Assets/Characters/Neon.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Duelist;
    }
}

