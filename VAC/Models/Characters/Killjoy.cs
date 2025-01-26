using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Killjoy : ICharacter
    {
        public string Name { get; set; } = "Killjoy";
        public string Splash { get; set; } = "/Assets/Characters/Killjoy.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Controller;
    }
}

