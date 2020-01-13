using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolphinAnalyzer.Models
{
    class Profile
    {
        public ProfileType ProfileType { get; set; }
        public ProfileShape ProfileShape { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Thickness { get; set; }
        public double Area { get; set; }
        public double InertiaX { get; set; }
        public double InertiaY { get; set; }
    }
}
