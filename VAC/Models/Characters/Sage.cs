using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Sage : ICharacter
    {
        public string Name { get; set; } = "Sage";
        public string Splash { get; set; } = "/Assets/Characters/Sage.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Sentinel;
    }
}

