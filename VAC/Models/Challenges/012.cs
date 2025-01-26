using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class _012 : IChallenge
    {
        public string Name { get; set; } = "All players camp a single site while defending";
        public IChallenge.Types Type { get; set; } = IChallenge.Types.Team;
        public uint Rounds { get; set; } = 3;
    }
}
