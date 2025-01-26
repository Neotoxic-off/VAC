using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Astra : ICharacter
    {
        public string Name { get; set; } = "Astra";
        public string Splash { get; set; } = "/Assets/Characters/Astra.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Controller;
    }
}
