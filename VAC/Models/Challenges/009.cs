using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Characters
{
    public class _009 : IChallenge
    {
        public string Name { get; set; } = "All players with sensitivity at 5";
        public IChallenge.Types Type { get; set; } = IChallenge.Types.Team;
        public uint Rounds { get; set; } = 3;
    }
}
