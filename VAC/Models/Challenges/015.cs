using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class _015 : IChallenge
    {
        public string Name { get; set; } = "All players plays without game sound";
        public IChallenge.Types Type { get; set; } = IChallenge.Types.Team;
        public uint Rounds { get; set; } = 2;
        public uint Reward { get; set; } = 5;
    }
}
