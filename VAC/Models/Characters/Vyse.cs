using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Vyse : ICharacter
    {
        public string Name { get; set; } = "Vyse";
        public string Splash { get; set; } = "/Assets/Characters/Vyse.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Sentinel;
    }
}

