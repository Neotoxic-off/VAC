using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Reyna : ICharacter
    {
        public string Name { get; set; } = "Reyna";
        public string Splash { get; set; } = "/Assets/Characters/Reyna.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Duelist;
    }
}

