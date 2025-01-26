using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class _003 : IChallenge
    {
        public string Name { get; set; } = "Everyone picks agents from the same class: Initiator";
        public IChallenge.Types Type { get; set; } = IChallenge.Types.Team;
        public uint Rounds { get; set; } = 0;
    }
}
