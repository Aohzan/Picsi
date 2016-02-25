using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picsi
{
    public class Pic
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Extension { get; set; }
        public DateTime ShotDate { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Tag { get; set; }
    }
}
