using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Clove : ICharacter
    {
        public string Name { get; set; } = "Clove";
        public string Splash { get; set; } = "/Assets/Characters/Clove.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Controller;
    }
}

