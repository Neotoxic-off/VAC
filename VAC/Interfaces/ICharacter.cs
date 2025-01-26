using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAC.Interfaces
{
    public interface ICharacter
    {
        public enum Types
        {
            Smoker,
            Sentinel,
            Duelist,
            Initiator
        }

        public string Name { get; set; }
        public Types Type { get; set; }
        public string Splash { get; set; }
    }
}
