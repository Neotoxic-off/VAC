using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class _021 : IChallenge
    {
        public string Name { get; set; } = "Players must remain crouched at all times";
        public IChallenge.Types Type { get; set; } = IChallenge.Types.Team;
        public uint Rounds { get; set; } = 2;
        public uint Reward { get; set; } = 2;
    }
}
