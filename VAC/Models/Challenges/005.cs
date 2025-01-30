using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class _005 : IChallenge
    {
        public string Name { get; set; } = "Entire team plays without using ultimates";
        public IChallenge.Types Type { get; set; } = IChallenge.Types.Team;
        public uint Rounds { get; set; } = 5;
        public uint Reward { get; set; } = 2;
    }
}
