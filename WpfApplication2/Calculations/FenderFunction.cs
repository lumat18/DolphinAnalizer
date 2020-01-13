using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DolphinAnalyzer.Models;
using DolphinAnalyzer.Parameters;

namespace DolphinAnalyzer.Calculations
{
    static class FenderFunction
    {
        public static void FunctionXm(Steel steel)
        {
            double fg = SoilParameters.SoilCoefficient;         // [kN/m3]
            double wx = GeometryParameters.GlobalModulusX;      // [m3]
            double fy = steel.YieldStrength*1000;                 // [MPa/10 = kN/m2]
            Results.SteelYieldStrength = fy/1000;           // [MPa]

            double Mmax = wx*fy;                            // [kNm]

            GeometryParameters.MaximumMoment = Mmax;

            double b = GeometryParameters.ConstructionWidth;    // [m]
            double h = GeometryParameters.ForceHeight;          // [m]

            double[] tabXm = new double[100];
            double Accuracy = 0.01;

            tabXm[0] = 1;
            tabXm[1] = 24 * Mmax / (fg * (3 * Math.Pow(tabXm[0], 3) + Math.Pow(tabXm[0], 2) * (4 * h + 8 * b) + 12 * h * b * tabXm[0]));
            tabXm[2] = (tabXm[1] + tabXm[0]) / 2;

            int i = 1;
            for (i = 1; (Math.Abs(tabXm[i] - tabXm[i - 1])) > Accuracy; i = i + 1 )
            {
                tabXm[2*i+1] = 24 * Mmax / (fg * (3 * Math.Pow(tabXm[2*i], 3) + Math.Pow(tabXm[2*i], 2) * (4 * h + 8 * b) + 12 * h * b * tabXm[2*i]));
                tabXm[2*(i+1)] = (tabXm[2*i+1] + tabXm[2*i]) / 2;
            }
            double Xm = tabXm[i];
            GeometryParameters.MomentDepth = Xm;

        }

        public static void Functiont0()
        {
            double b = GeometryParameters.ConstructionWidth;    // [m]
            double h = GeometryParameters.ForceHeight;          // [m]

            double Xm = GeometryParameters.MomentDepth;

            double[] tabt0 = new double[100];
            double Accuracy = 0.01;
            
            tabt0[0] = 1;
            tabt0[1] = Math.Pow((tabt0[0] + h) / (tabt0[0] + 4 * b) * 4 * Math.Pow(Xm, 2) * (Xm  +3 * b), 0.333);
            tabt0[2] = (tabt0[1] + tabt0[0]) / 2;

            int i = 1;
            for (i=1; (Math.Abs(tabt0[i]-tabt0[i-1]))>Accuracy; i=i+1)
            {
                tabt0[2*i+1] = Math.Pow((tabt0[2*i] + h) / (tabt0[2*i] + 4 * b) * 4 * Math.Pow(Xm, 2) * (Xm + 3 * b), 0.333);
                tabt0[2*(i+1)] = (tabt0[2*i+1] + tabt0[2*i]) / 2;
            }
            double t0 = tabt0[i];
            GeometryParameters.DolphinDepth = t0;
        }
        public static void FunctionMaxP()
        {
            double fg = SoilParameters.SoilCoefficient;         // [kN/m3]
            double Xm = GeometryParameters.MomentDepth;         // [m]
            double b = GeometryParameters.ConstructionWidth;    // [m]

            double P = fg/6*Math.Pow(Xm, 2)*(Xm + 3*b);         //[kN]

            Results.MaximalForce = P;
        }
        public static void Functiond(Steel steel)
        {
            double p = Results.MaximalForce;                        // [kN]

            double h = GeometryParameters.ForceHeight;              // [m]
            double t0 = GeometryParameters.DolphinDepth;            // [m]

            double E = steel.YoungsModulus * Math.Pow(10,6);        // [kN/m2]
            double Ix = GeometryParameters.GlobalInetriaX;   // [m4]      

            double d = p*Math.Pow(h + 0.65*t0, 3)/(3*E*Ix);         // [m]

            Results.Deflection = d;

        }

        public static void FunctionPotentialEnergyOfElasticDeflection()
        {
            double P = Results.MaximalForce;        // [kN]
            double d = Results.Deflection;          // [m]

            double Ep = P*d/2;                      // [kN*m = kJ]

            Results.PotentialEnergyOfElasticDeflection = Ep;
        }

        public static void FunctionBerthingEnergy()
        {
            double m = ShipParameters.M;                                // [t]              
            double v = ApproachParameters.Velocity;                     // [m/s]
            double Ce = ApproachParameters.EccentricityCoefficient;     // [-]
            double Cm = ApproachParameters.AddedMassCoefficient;        // [-]
            double Cs = ApproachParameters.SoftnessCoefficient;         // [-]

            double Ek = m*Math.Pow(v, 2)/2*Ce*Cm*Cs;                    // [t*m2/s2 = 1000kg*m/s2 * m = kN*m = kJ]

            Results.BerthingEnergy = Ek;
        }

        public static void FunctionStabilityCondition(double Fb)
        {
            double Ek = Results.BerthingEnergy;
            double Ep = Results.PotentialEnergyOfElasticDeflection;
            double Ew = Ek*Fb;

            double ratio = Ew/Ep;

            Results.StabilityCondition = ratio;
        }
    }
}
