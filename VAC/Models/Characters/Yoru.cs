using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Yoru : ICharacter
    {
        public string Name { get; set; } = "Yoru";
        public string Splash { get; set; } = "/Assets/Characters/Yoru.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Duelist;
    }
}
