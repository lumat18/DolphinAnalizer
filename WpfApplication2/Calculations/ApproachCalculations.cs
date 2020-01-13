using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolphinAnalyzer.Tabs
{
    static class ApproachCalculations
    {
        public static void ApproachParametersCalc(double alfa, double x, string formula, double Rt)
        {
            double Lpp = ShipParameters.Lpp;
            double B = ShipParameters.Bc;
            double d = ShipParameters.Delta;
            double a = alfa*Math.PI/180;
            double T = ShipParameters.Tc;

            double y = Lpp/2 - x;
            double R = Math.Pow(Math.Pow(y,2)+Math.Pow(B/2,2), 0.5);
            double k = (0.19*d + 0.11)*Lpp;

            ApproachParameters.Radius = R;
            ApproachParameters.RadiusOfGyration = k;

            double fi = Math.Atan(2*y/B)-a;     // [rad]

            double ce = (Math.Pow(k,2)+Math.Pow(R,2)*Math.Pow(Math.Cos(fi),2))/(Math.Pow(k,2)+Math.Pow(R,2));

            ApproachParameters.EccentricityCoefficient = ce;

            double ratio = Rt/T;
            double cm = 1;

            if (formula == "PIANC")
            {
                if (ratio > 0.5)
                {
                    cm = 1.5;
                }
                else if (ratio > 0.1)
                {
                    cm = 1.875 - 0.75*ratio;
                }
                else
                {
                    cm = 1.8;
                }
            }
            else if (formula == "Ueda")
            {
                cm = Math.PI*T/(2*d*B);
            }
            else if (formula == "Vasco Costa")
            {
                cm = 1 + 2 * T / B;
            }
            ApproachParameters.AddedMassCoefficient = cm;


        }
    }
}
