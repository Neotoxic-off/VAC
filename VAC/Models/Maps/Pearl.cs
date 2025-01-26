using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Maps
{
    public class Pearl : IMap
    {
        public string Name { get; set; } = "Pearl";
        public string Splash { get; set; } = "/Assets/Maps/Pearl.avif";
    }
}
