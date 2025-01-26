using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Cypher : ICharacter
    {
        public string Name { get; set; } = "Cypher";
        public string Splash { get; set; } = "/Assets/Characters/Cypher.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Sentinel;
    }
}

