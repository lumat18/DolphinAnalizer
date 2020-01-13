using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DolphinAnalyzer
{
    static class SoilCalculations
    {
        public static void SoilParametersCalc(Soil soil, double Id)
        {
            double wn;
            double ro;

            if (Id >= 0.68)
            {
                wn = soil.wn1;
                ro = soil.ro1;
            }
            else if (Id >= 0.33)
            {
                wn = soil.wn2;
                ro = soil.ro2;
            }
            else
            {
                wn = soil.wn3;
                ro = soil.ro3;
            }

            double fi = 1;
            if (soil.SoilType == SoilType.Gravel)
            {
                fi = 36.5 + 5.5*(Id - 0.2)/0.8;
            }
            else if (soil.SoilType == SoilType.CroarseSand)
            {
                fi = 31 + 5*(Id - 0.2)/0.8;
            }
            else if (soil.SoilType == SoilType.MediumSand)
            {
                fi = 31 + 5 * (Id - 0.2) / 0.8;
            }
            else if (soil.SoilType == SoilType.FineSand)
            {
                fi = 29 + 4*(Id - 0.2)/0.8;
            }
            else if (soil.SoilType == SoilType.DustySand)
            {
                fi = 29 + 4 * (Id - 0.2) / 0.8;
            }

            double d = -fi/2;
            double ros = soil.ros;
            double n = (ros*(1+wn)-ro)/(ros*(1+wn));
            double row = 1.025;
            double g = 9.81;
            double gammap = (1 - n)*(ros - row)*g;
            double firad = fi*Math.PI/180;
            double drad = d*Math.PI/180;
            double kph = Math.Pow(Math.Cos(firad), 2)/Math.Pow(1-Math.Pow(Math.Sin(firad-drad)*Math.Sin(firad)/Math.Cos(drad),0.5), 2);
            double fg = kph*gammap;

            SoilParameters.SoilType = soil.SoilType;
            SoilParameters.DegreeOfCompaction = Id;
            SoilParameters.AngleOfSelfFriction = fi;
            SoilParameters.AngleOfWallFriction = d;
            SoilParameters.SaturatedVolumeWeight = gammap;
            SoilParameters.Porosity = n;
            SoilParameters.DensityOfSoilSkeleton = ros;
            SoilParameters.SoilDensity = ro;
            SoilParameters.CoefficientOfPassivePressure = kph;
            SoilParameters.SoilCoefficient = fg;

        }
    }
}
