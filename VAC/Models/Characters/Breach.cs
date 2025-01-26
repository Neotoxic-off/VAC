using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Breach : ICharacter
    {
        public string Name { get; set; } = "Breach";
        public string Splash { get; set; } = "/Assets/Characters/Breach.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Initiator;
    }
}

