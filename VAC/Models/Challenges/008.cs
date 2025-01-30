using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class _008 : IChallenge
    {
        public string Name { get; set; } = "Designate 3 players to push one site and 2 players the other site";
        public IChallenge.Types Type { get; set; } = IChallenge.Types.Team;
        public uint Rounds { get; set; } = 5;
        public uint Reward { get; set; } = 2;
    }
}
