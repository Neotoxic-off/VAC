using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models
{
    public class MapFilter
    {
        public IMap Map { get; set; }
        public bool Selected { get; set; }

        public MapFilter(IMap map, bool selected)
        {
            Map = map;
            Selected = selected;
        }
    }
}
