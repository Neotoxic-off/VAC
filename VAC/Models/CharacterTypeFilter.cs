using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models
{
    public class CharacterTypeFilter
    {
        public ICharacter.Types Type { get; set; }
        public bool Selected { get; set; }

        public CharacterTypeFilter(ICharacter.Types type, bool selected)
        {
            Type = type;
            Selected = selected;
        }
    }
}
