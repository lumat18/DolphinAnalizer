using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DolphinAnalyzer.Models;
using DolphinAnalyzer.Parameters;

namespace DolphinAnalyzer.Calculations
{
    static class BollardCalculations
    {
        public static void BollardParametersCalc(Bollard bollard)
        {
            MooringParameters.BollardType = bollard.BollardType;
            MooringParameters.BollardBearingCapacity = bollard.BearingCapacity;
            double Hdop = GeometryParameters.LimitDepth;
            double Hd = GeometryParameters.SpaceUnder;
            double Hc = GeometryParameters.CapHeight;
            double Hb = bollard.Height/1000;                // [mm/1000 = m]
            MooringParameters.BollardHeight = Hb;
            double Hz = Hdop + Hd + Hc + Hb;
            MooringParameters.ForceHeight = Hz;

            MooringFunction.UseAll();
        }
    }
}
