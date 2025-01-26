using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Skye : ICharacter
    {
        public string Name { get; set; } = "Skye";
        public string Splash { get; set; } = "/Assets/Characters/Skye.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Initiator;
    }
}

