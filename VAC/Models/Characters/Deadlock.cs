using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class Deadlock : ICharacter
    {
        public string Name { get; set; } = "Deadlock";
        public string Splash { get; set; } = "/Assets/Characters/Deadlock.avif";
        public ICharacter.Types Type { get; set; } = ICharacter.Types.Sentinel;
    }
}

