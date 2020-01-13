using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using DolphinAnalyzer.Models;
using DolphinAnalyzer.Parameters;

namespace DolphinAnalyzer.Calculations
{
    static class GeometryCalculations
    {
        public static void GeometryParametersCalc(Profile profile, Steel steel, double x, double y, double a, double b)
        {
            GeometryParameters.SteelType = steel.SteelType;
            GeometryParameters.HorizontalAmount = a;
            GeometryParameters.VertiaclAmount = b;
            GeometryParameters.HorizontalSpacing = x;
            GeometryParameters.VertiaclSpacing = y;

            if (profile.ProfileShape == ProfileShape.Cycylindric)
            {
                GeometryParameters.ProfileType = profile.ProfileType;

                double D = profile.Height / 10;                 // [mm/10 = cm]
                double GlobalHeight = D + (b - 1) * y*100;      // [cm]
                double GlobalWidth = D + (a - 1) * x*100;       // [cm]
                double ey = GlobalHeight / 2;                     // [cm]
                double ex = GlobalWidth / 2;                      // [cm]
                double I = profile.InertiaX;                    // [cm4]
                double A = profile.Area;                        // [cm2]

                double Ix = 0;
                double Iy = 0;

                double Qy = 1;
                double i = 1;
                double j = 1;

                for (i = 1; i <= a; i = i + 1)
                {
                    double Qx = 1;

                    for (j = 1; j <= b; j = j + 1)
                    {
                        Ix = Ix + I + A*Math.Pow(y*100*(b-Qx)/2, 2);      // [cm4]
                        Qx = Qx + 2;
                        Iy = Iy + I + A*Math.Pow(x*100*(a-Qy)/2, 2);      // [cm4]
                    }
                    Qy = Qy + 2;
                }

                GeometryParameters.GlobalInetriaX = Ix/Math.Pow(100,4);
                GeometryParameters.GlobalInertiaY = Iy/Math.Pow(100,4);

                double Wx = Ix / ey;          // [cm3]
                double Wy = Iy / ex;          // [cm3]

                GeometryParameters.GlobalModulusX = Wx/Math.Pow(100,3);
                GeometryParameters.GlobalModulusY = Wy/Math.Pow(100,3);
            }
            else if (profile.ProfileShape == ProfileShape.Peine)
            {
                
            }
            
            double Hdop = ApproachParameters.DepthMargin + ShipParameters.Tc;
            GeometryParameters.LimitDepth = Hdop;

            double Hp = GeometryParameters.CapHeight/2 + GeometryParameters.SpaceUnder + Hdop;
            GeometryParameters.ForceHeight = Hp;

            FenderFunction.FunctionXm(steel);
            FenderFunction.Functiont0();
            FenderFunction.FunctionMaxP();
            FenderFunction.Functiond(steel);
            FenderFunction.FunctionPotentialEnergyOfElasticDeflection();
            FenderFunction.FunctionBerthingEnergy();

        }
    }
}
