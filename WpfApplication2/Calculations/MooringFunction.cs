using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DolphinAnalyzer.Parameters;

namespace DolphinAnalyzer.Calculations
{
    static class MooringFunction
    {
        public static void UseAll()
        {
            FunctionXm();
            FunctionMmax();
            DiagonalBending();
        }
        public static void FunctionXm()
        {
            double g = 10;
            double Z = MooringParameters.BollardBearingCapacity*g;      // [t * m/s2 = kN]
            double fg = SoilParameters.SoilCoefficient;                 // [kN/m3]
            double b = GeometryParameters.ConstructionWidth;            // [m]

            double[] tabXm = new double[100];
            double Accuracy = 0.01;
            tabXm[0] = 1;
            tabXm[1] = Math.Sqrt(6 * Z / (fg * (tabXm[0] + 3 * b)));
            tabXm[2] = (tabXm[1] + tabXm[0]) / 2;
            
            int i = 1;

            for (i = 1; Math.Abs(tabXm[i] - tabXm[i - 1]) > Accuracy; i = i + 1)
            {
                tabXm[2 * i + 1] = Math.Sqrt(6 * Z / (fg * (tabXm[2 * i] + 3 * b)));
                tabXm[2 * (i + 1)] = (tabXm[2 * i + 1] + tabXm[2 * i]) / 2;
            }
            double Xm = tabXm[i];
            MooringParameters.MomentDepth = Xm;         // [m]
        }

        public static void FunctionMmax()
        {
            double Xm = MooringParameters.MomentDepth;          // [m]
            double fg = SoilParameters.SoilCoefficient;         // [kN/m3]
            double b = GeometryParameters.ConstructionWidth;    // [m]
            double hz = MooringParameters.ForceHeight;          // [m]

            double Mmax = fg/24*Math.Pow(Xm, 2)*(3*Math.Pow(Xm, 2) + Xm*(4*hz + 8*b) + 12*hz*b);

            MooringParameters.MaximumMoment = Mmax;             // [kNm]
        }

        public static void DiagonalBending()
        {
            double Wx = GeometryParameters.GlobalModulusX;   // [m3]
            double Wy = GeometryParameters.GlobalModulusY;     // [m3]
            double alfaM = Math.Atan(Wx/Wy);                    // [rad]

            double M = MooringParameters.MaximumMoment;         // [kNm]
            double Mx = M*Math.Cos(alfaM);                      // [kNm]
            double My = M*Math.Sin(alfaM);                      // [kNm]

            MooringParameters.MomentX = Mx;
            MooringParameters.MomentY = My;

            double SP1 = Mx / Wx + My / Wy;                         // [kN/m2]
            double SP2 = -Mx / Wx - My / Wy;                        // [kN/m2]

            MooringParameters.StressP1 = SP1/1000;                       // [MPa]
            MooringParameters.StressP2 = SP2/1000;                       // [MPa]
            MooringParameters.MooringAngleAlfa = alfaM*180/Math.PI;             // [o]

        }

        public static void StressCondition()
        {
            double fy = Results.SteelYieldStrength;         // [MPa]
            double SP1 = MooringParameters.StressP1;        // [MPa]
            double SP2 = MooringParameters.StressP2;

            double ratio1 = SP1/fy;
            double ratio2 = SP2/fy;

            Results.StressCondition1 = ratio1;
            Results.StressCondition2 = ratio2;
        }



    }
}
