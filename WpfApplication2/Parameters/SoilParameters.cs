using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolphinAnalyzer
{
    static class SoilParameters
    {
        public static SoilType SoilType { get; set; }
        public static double DegreeOfCompaction { get; set; }
        public static double AngleOfSelfFriction { get; set; }
        public static double AngleOfWallFriction { get; set; }
        public static double SaturatedVolumeWeight { get; set; }
        public static double Porosity { get; set; }
        public static double DensityOfSoilSkeleton { get; set; }
        public static double SoilDensity { get; set; }


        public static double CoefficientOfPassivePressure { get; set; }
        public static double SoilCoefficient { get; set; }
    }
}
