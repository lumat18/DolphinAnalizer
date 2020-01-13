using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolphinAnalyzer.Models
{
    class Bollard
    {
        public BollardType BollardType { get; set; }
        public double BearingCapacity { get; set; }
        public double Height { get; set; }
    }
}
