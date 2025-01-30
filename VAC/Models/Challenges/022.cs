using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class _022 : IChallenge
    {
        public string Name { get; set; } = "No one is allowed to use full-auto weapons";
        public IChallenge.Types Type { get; set; } = IChallenge.Types.Team;
        public uint Rounds { get; set; } = 3;
        public uint Reward { get; set; } = 2;
    }
}
