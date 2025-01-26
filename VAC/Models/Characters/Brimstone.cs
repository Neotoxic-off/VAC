using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Brimstone : ICharacter
    {
        public string Name { get; set; } = "Brimstone";
        public string Splash { get; set; } = "/Assets/Characters/Brimstone.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Controller;
    }
}

