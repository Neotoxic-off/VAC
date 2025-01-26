using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.Models.Maps
{
    public class Haven : IMap
    {
        public string Name { get; set; } = "Haven";
        public string Splash { get; set; } = "/Assets/Maps/Haven.avif";
    }
}
