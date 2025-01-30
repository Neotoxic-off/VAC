using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAC.Interfaces
{
    public interface IChallenge
    {
        public enum Types
        {
            Solo,
            Duo,
            Team
        }

        public string Name { get; set; }
        public Types Type { get; set; }
        public uint Rounds { get; set; }
        public uint Reward { get; set; }
    }
}
