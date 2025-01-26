using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Sova : ICharacter
    {
        public string Name { get; set; } = "Sova";
        public string Splash { get; set; } = "/Assets/Characters/Sova.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Initiator;
    }
}

