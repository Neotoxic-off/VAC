using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Chamber : ICharacter
    {
        public string Name { get; set; } = "Chamber";
        public string Splash { get; set; } = "/Assets/Characters/Chamber.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Sentinel;
    }
}

