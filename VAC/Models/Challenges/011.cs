using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class _011 : IChallenge
    {
        public string Name { get; set; } = "Use all 5 ultimates in the same round";
        public IChallenge.Types Type { get; set; } = IChallenge.Types.Team;
        public uint Rounds { get; set; } = 1;
        public uint Reward { get; set; } = 2;
    }
}
