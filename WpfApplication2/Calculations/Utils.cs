using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolphinAnalyzer
{
    public static class Utils
    {
        static public void InterpolateDWT(double DWT, Ship BiggerShip, Ship SmallerShip)
        {
            double DWTDifference = BiggerShip.DWT  - SmallerShip.DWT;
            double DisplacementDifference = BiggerShip.Displacement - SmallerShip.Displacement;
            double LengthOfAllDifference = BiggerShip.LengthOfAll - SmallerShip.LengthOfAll;
            double LengthPPDifference = BiggerShip.LengthPP - SmallerShip.LengthPP;
            double WidthDifference = BiggerShip.Width - SmallerShip.Width;
            double DraftDifference = BiggerShip.Draft - SmallerShip.Draft;

            double GivenDifference = DWT - SmallerShip.DWT;

            ShipParameters.DWT = (DWTDifference*GivenDifference)/DWTDifference + SmallerShip.DWT;
            ShipParameters.M = (DisplacementDifference*GivenDifference)/DWTDifference + SmallerShip.Displacement;
            ShipParameters.Lcc = (LengthOfAllDifference*GivenDifference)/DWTDifference + SmallerShip.LengthOfAll;
            ShipParameters.Lpp = (LengthPPDifference*GivenDifference)/DWTDifference + SmallerShip.LengthPP;
            ShipParameters.Bc = (WidthDifference*GivenDifference)/DWTDifference + SmallerShip.Width;
            ShipParameters.Tc = (DraftDifference*GivenDifference)/DWTDifference + SmallerShip.Draft;
            BlockCoefficient(ShipParameters.M, ShipParameters.Lpp, ShipParameters.Bc, ShipParameters.Tc );
        }
        static public void InterpolateDisplacement(double Displacement, Ship BiggerShip, Ship SmallerShip)
        {
            double DWTDifference = BiggerShip.DWT - SmallerShip.DWT;
            double DisplacementDifference = BiggerShip.Displacement - SmallerShip.Displacement;
            double LengthOfAllDifference = BiggerShip.LengthOfAll - SmallerShip.LengthOfAll;
            double LengthPPDifference = BiggerShip.LengthPP - SmallerShip.LengthPP;
            double WidthDifference = BiggerShip.Width - SmallerShip.Width;
            double DraftDifference = BiggerShip.Draft - SmallerShip.Draft;

            double GivenDifference = Displacement - SmallerShip.Displacement;

            ShipParameters.DWT = (DWTDifference * GivenDifference) / DisplacementDifference + SmallerShip.DWT;
            ShipParameters.M = (DisplacementDifference * GivenDifference) / DisplacementDifference + SmallerShip.Displacement;
            ShipParameters.Lcc = (LengthOfAllDifference * GivenDifference) / DisplacementDifference + SmallerShip.LengthOfAll;
            ShipParameters.Lpp = (LengthPPDifference * GivenDifference) / DisplacementDifference + SmallerShip.LengthPP;
            ShipParameters.Bc = (WidthDifference * GivenDifference) / DisplacementDifference + SmallerShip.Width;
            ShipParameters.Tc = (DraftDifference * GivenDifference) / DisplacementDifference + SmallerShip.Draft;
            BlockCoefficient( ShipParameters.M, ShipParameters.Lpp, ShipParameters.Bc, ShipParameters.Tc );
        } 


        public static bool IsNumeric(this string s)
        {
            double output;
            return double.TryParse(s, out output);
        }

        public static void BlockCoefficient(double Displacement, double LengthPP, double Width, double Draft)
        {
            double Water = 1.025;
            ShipParameters.Delta = Displacement/(LengthPP*Width*Draft*Water);
        }

        public static String Round2Str(this double s)
        {
            return String.Format("{0:0.000}", s);
        }
    }
}
