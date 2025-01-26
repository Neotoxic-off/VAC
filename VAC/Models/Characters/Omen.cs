using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Omen : ICharacter
    {
        public string Name { get; set; } = "Omen";
        public string Splash { get; set; } = "/Assets/Characters/Omen.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Controller;
    }
}

