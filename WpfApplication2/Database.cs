using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DolphinAnalyzer.Models;

namespace DolphinAnalyzer
{
    class Database
    {
        public List<Ship> Ships { get; set; }
        public List<Soil> Soils { get; set; } 
        public List<Profile> Profiles { get; set; }
        public List<Steel> Steels { get; set; }
        public List<Bollard> Bollards { get; set; } 
        public Database()
        {
            Ships = new List<Ship>
            {
                new Ship() { ShipType = ShipType.Passenger, DWT = 1000, Displacement = 850, LengthOfAll = 60, LengthPP = 54, Width = 11.4, Draft = 1.9 },
                new Ship() { ShipType = ShipType.Passenger, DWT = 2000, Displacement = 1580, LengthOfAll = 76, LengthPP = 68, Width = 13.6, Draft = 2.5 },
                new Ship() { ShipType = ShipType.Passenger, DWT = 3000, Displacement = 2270, LengthOfAll = 87, LengthPP = 78, Width = 15.1, Draft = 3.0 },
                new Ship() { ShipType = ShipType.Passenger, DWT = 5000, Displacement = 3580, LengthOfAll = 104, LengthPP = 92, Width = 17.1, Draft = 3.6 },
                new Ship() { ShipType = ShipType.Passenger, DWT = 7000, Displacement = 4830, LengthOfAll = 117, LengthPP = 103, Width = 18.6, Draft = 4.1 },
                new Ship() { ShipType = ShipType.Passenger, DWT = 10000, Displacement = 6600, LengthOfAll = 133, LengthPP = 116, Width = 20.4, Draft = 4.8 },
                new Ship() { ShipType = ShipType.Passenger, DWT = 15000, Displacement = 9500, LengthOfAll = 153, LengthPP = 132, Width = 22.5, Draft = 5.6 },
                new Ship() { ShipType = ShipType.Passenger, DWT = 20000, Displacement = 12300, LengthOfAll = 169, LengthPP = 146, Width = 24.2, Draft = 7.6 },
                new Ship() { ShipType = ShipType.Passenger, DWT = 30000, Displacement = 17700, LengthOfAll = 194, LengthPP = 166, Width = 26.8, Draft = 7.6 },
                new Ship() { ShipType = ShipType.Passenger, DWT = 50000, Displacement = 27900, LengthOfAll = 231, LengthPP = 197, Width = 30.5, Draft = 7.6 },
                new Ship() { ShipType = ShipType.Passenger, DWT = 70000, Displacement = 37600, LengthOfAll = 260, LengthPP = 220, Width = 33.1, Draft = 7.6 },
                new Ship() { ShipType = ShipType.Passenger, DWT = 90000, Displacement = 48000, LengthOfAll = 293, LengthPP = 264, Width = 33.2, Draft = 8.2 },

                new Ship() { ShipType = ShipType.Tanker, DWT = 1000, Displacement = 1450, LengthOfAll = 59, LengthPP = 54, Width = 9.7, Draft = 3.8 },
                new Ship() { ShipType = ShipType.Tanker, DWT = 2000, Displacement = 2810, LengthOfAll = 73, LengthPP = 68, Width = 12.1, Draft = 4.7 },
                new Ship() { ShipType = ShipType.Tanker, DWT = 3000, Displacement = 4140, LengthOfAll = 83, LengthPP = 77, Width = 13.7, Draft = 5.3 },
                new Ship() { ShipType = ShipType.Tanker, DWT = 5000, Displacement = 6740, LengthOfAll = 97, LengthPP = 91, Width = 16.0, Draft = 6.1 },
                new Ship() { ShipType = ShipType.Tanker, DWT = 7000, Displacement = 9300, LengthOfAll = 108, LengthPP = 102, Width = 17.8, Draft = 6.7 },
                new Ship() { ShipType = ShipType.Tanker, DWT = 10000, Displacement = 13100, LengthOfAll = 121, LengthPP = 114, Width = 19.9, Draft = 7.5 },
                new Ship() { ShipType = ShipType.Tanker, DWT = 15000, Displacement = 19200, LengthOfAll = 138, LengthPP = 130, Width = 22.5, Draft = 8.4 },
                new Ship() { ShipType = ShipType.Tanker, DWT = 20000, Displacement = 25300, LengthOfAll = 151, LengthPP = 143, Width = 24.6, Draft = 9.1 },
                new Ship() { ShipType = ShipType.Tanker, DWT = 30000, Displacement = 37300, LengthOfAll = 171, LengthPP = 163, Width = 27.9, Draft = 10.3 },
                new Ship() { ShipType = ShipType.Tanker, DWT = 50000, Displacement = 60800, LengthOfAll = 201, LengthPP = 192, Width = 32.3, Draft = 11.9 },
                new Ship() { ShipType = ShipType.Tanker, DWT = 70000, Displacement = 83900, LengthOfAll = 224, LengthPP = 214, Width = 36.3, Draft = 13.2 },
                new Ship() { ShipType = ShipType.Tanker, DWT = 100000, Displacement = 118000, LengthOfAll = 250, LengthPP = 240, Width = 40.6, Draft = 14.6 },
                new Ship() { ShipType = ShipType.Tanker, DWT = 150000, Displacement = 174000, LengthOfAll = 284, LengthPP = 273, Width = 46.0, Draft = 16.4 },
                new Ship() { ShipType = ShipType.Tanker, DWT = 200000, Displacement = 229000, LengthOfAll = 311, LengthPP = 300, Width = 50.3, Draft = 17.9 },
                new Ship() { ShipType = ShipType.Tanker, DWT = 300000, Displacement = 337000, LengthOfAll = 354, LengthPP = 342, Width = 57, Draft = 20.1 },

                new Ship() { ShipType = ShipType.LNG, DWT = 10000, Displacement = 19000, LengthOfAll = 148, LengthPP = 135, Width = 26, Draft = 7.0 },
                new Ship() { ShipType = ShipType.LNG, DWT = 20000, Displacement = 34000, LengthOfAll = 195, LengthPP = 185, Width = 30, Draft = 8.5 },
                new Ship() { ShipType = ShipType.LNG, DWT = 50000, Displacement = 75000, LengthOfAll = 255, LengthPP = 245, Width = 38, Draft = 10.5 },
                new Ship() { ShipType = ShipType.LNG, DWT = 70000, Displacement = 100000, LengthOfAll = 280, LengthPP = 269, Width = 45, Draft = 11.5 },
                new Ship() { ShipType = ShipType.LNG, DWT = 100000, Displacement = 125000, LengthOfAll = 305, LengthPP = 294, Width = 50, Draft = 12.5 },

                new Ship() { ShipType = ShipType.LPG, DWT = 2000, Displacement = 3500, LengthOfAll = 90, LengthPP = 75, Width = 13, Draft = 5.5 },
                new Ship() { ShipType = ShipType.LPG, DWT = 5000, Displacement = 8000, LengthOfAll = 110, LengthPP = 100, Width = 18, Draft = 6.8 },
                new Ship() { ShipType = ShipType.LPG, DWT = 10000, Displacement = 15000, LengthOfAll = 130, LengthPP = 130, Width = 21, Draft = 9 },
                new Ship() { ShipType = ShipType.LPG, DWT = 20000, Displacement = 27000, LengthOfAll = 170, LengthPP = 160, Width = 25, Draft = 10.5 },
                new Ship() { ShipType = ShipType.LPG, DWT = 50000, Displacement = 65000, LengthOfAll = 230, LengthPP = 220, Width = 35, Draft = 13 },
                new Ship() { ShipType = ShipType.LPG, DWT = 70000, Displacement = 90000, LengthOfAll = 260, LengthPP = 250, Width = 38, Draft = 14 },

                new Ship() { ShipType = ShipType.Container, DWT = 7000, Displacement = 10300, LengthOfAll = 118, LengthPP = 109, Width = 20.1, Draft = 6.8 },
                new Ship() { ShipType = ShipType.Container, DWT = 10000, Displacement = 14200, LengthOfAll = 135, LengthPP = 126, Width = 20.8, Draft = 7.6 },
                new Ship() { ShipType = ShipType.Container, DWT = 15000, Displacement = 20900, LengthOfAll = 158, LengthPP = 148, Width = 23.3, Draft = 8.7 },
                new Ship() { ShipType = ShipType.Container, DWT = 20000, Displacement = 27500, LengthOfAll = 177, LengthPP = 165, Width = 25.5, Draft = 9.5 },
                new Ship() { ShipType = ShipType.Container, DWT = 25000, Displacement = 34100, LengthOfAll = 192, LengthPP = 181, Width = 28.8, Draft = 10.2 },
                new Ship() { ShipType = ShipType.Container, DWT = 30000, Displacement = 40700, LengthOfAll = 206, LengthPP = 194, Width = 30.2, Draft = 10.8 },
                new Ship() { ShipType = ShipType.Container, DWT = 40000, Displacement = 53900, LengthOfAll = 230, LengthPP = 217, Width = 32.3, Draft = 11.8 },
                new Ship() { ShipType = ShipType.Container, DWT = 50000, Displacement = 67200, LengthOfAll = 250, LengthPP = 237, Width = 32.3, Draft = 12.6 },
                new Ship() { ShipType = ShipType.Container, DWT = 60000, Displacement = 80400, LengthOfAll = 268, LengthPP = 254, Width = 32.3, Draft = 13.4 },
                new Ship() { ShipType = ShipType.Container, DWT = 70000, Displacement = 93600, LengthOfAll = 285, LengthPP = 270, Width = 40.3, Draft = 14.0 },
                new Ship() { ShipType = ShipType.Container, DWT = 80000, Displacement = 107000, LengthOfAll = 300, LengthPP = 284, Width = 40.3, Draft = 14.5 },
                new Ship() { ShipType = ShipType.Container, DWT = 90000, Displacement = 120000, LengthOfAll = 313, LengthPP = 298, Width = 42.8, Draft = 14.5 },
                new Ship() { ShipType = ShipType.Container, DWT = 100000, Displacement = 133000, LengthOfAll = 326, LengthPP = 310, Width = 42.8, Draft = 14.5 },
                new Ship() { ShipType = ShipType.Container, DWT = 110000, Displacement = 150000, LengthOfAll = 350, LengthPP = 334, Width = 45.6, Draft = 14.4 },
                new Ship() { ShipType = ShipType.Container, DWT = 152000, Displacement = 205000, LengthOfAll = 390, LengthPP = 378, Width = 54.2, Draft = 14.5 },

                new Ship() { ShipType = ShipType.Cargo, DWT = 1000, Displacement = 1580, LengthOfAll = 63, LengthPP = 58, Width = 10.3, Draft = 3.6 },
                new Ship() { ShipType = ShipType.Cargo, DWT = 2000, Displacement = 3040, LengthOfAll = 78, LengthPP = 72, Width = 12.4, Draft = 4.5 },
                new Ship() { ShipType = ShipType.Cargo, DWT = 3000, Displacement = 4460, LengthOfAll = 88, LengthPP = 82, Width = 13.9, Draft = 5.1 },
                new Ship() { ShipType = ShipType.Cargo, DWT = 5000, Displacement = 7210, LengthOfAll = 104, LengthPP = 96, Width = 16.0, Draft = 6.1 },
                new Ship() { ShipType = ShipType.Cargo, DWT = 7000, Displacement = 9900, LengthOfAll = 115, LengthPP = 107, Width = 17.6, Draft = 6.8 },
                new Ship() { ShipType = ShipType.Cargo, DWT = 10000, Displacement = 13900, LengthOfAll = 128, LengthPP = 120, Width = 19.5, Draft = 7.6 },
                new Ship() { ShipType = ShipType.Cargo, DWT = 15000, Displacement = 20300, LengthOfAll = 146, LengthPP = 136, Width = 21.8, Draft = 8.7 },
                new Ship() { ShipType = ShipType.Cargo, DWT = 20000, Displacement = 26600, LengthOfAll = 159, LengthPP = 149, Width = 23.6, Draft = 9.6 },
                new Ship() { ShipType = ShipType.Cargo, DWT = 30000, Displacement = 39000, LengthOfAll = 181, LengthPP = 170, Width = 26.4, Draft = 10.9 },
                new Ship() { ShipType = ShipType.Cargo, DWT = 40000, Displacement = 51100, LengthOfAll = 197, LengthPP = 186, Width = 28.6, Draft = 12.0 },
                
                new Ship() { ShipType = ShipType.BulkCarrier, DWT = 5000, Displacement = 6740, LengthOfAll = 106, LengthPP = 98, Width = 15.0, Draft = 6.1 },
                new Ship() { ShipType = ShipType.BulkCarrier, DWT = 7000, Displacement = 9270, LengthOfAll = 116, LengthPP = 108, Width = 16.6, Draft = 6.7 },
                new Ship() { ShipType = ShipType.BulkCarrier, DWT = 10000, Displacement = 13000, LengthOfAll = 129, LengthPP = 120, Width = 18.5, Draft = 7.5 },
                new Ship() { ShipType = ShipType.BulkCarrier, DWT = 15000, Displacement = 19100, LengthOfAll = 145, LengthPP = 135, Width = 21.0, Draft = 8.4 },
                new Ship() { ShipType = ShipType.BulkCarrier, DWT = 20000, Displacement = 25000, LengthOfAll = 157, LengthPP = 148, Width = 23.0, Draft = 9.2 },
                new Ship() { ShipType = ShipType.BulkCarrier, DWT = 30000, Displacement = 36700, LengthOfAll = 176, LengthPP = 167, Width = 26.1, Draft = 10.3 },
                new Ship() { ShipType = ShipType.BulkCarrier, DWT = 50000, Displacement = 59600, LengthOfAll = 204, LengthPP = 194, Width = 32.3, Draft = 12.0 },
                new Ship() { ShipType = ShipType.BulkCarrier, DWT = 70000, Displacement = 81900, LengthOfAll = 224, LengthPP = 215, Width = 32.3, Draft = 13.3 },
                new Ship() { ShipType = ShipType.BulkCarrier, DWT = 100000, Displacement = 115000, LengthOfAll = 248, LengthPP = 239, Width = 37.9, Draft = 14.8 },
                new Ship() { ShipType = ShipType.BulkCarrier, DWT = 150000, Displacement = 168000, LengthOfAll = 279, LengthPP = 270, Width = 43.0, Draft = 16.7 },
                new Ship() { ShipType = ShipType.BulkCarrier, DWT = 200000, Displacement = 221000, LengthOfAll = 303, LengthPP = 294, Width = 47.0, Draft = 18.2 },
                new Ship() { ShipType = ShipType.BulkCarrier, DWT = 250000, Displacement = 273000, LengthOfAll = 322, LengthPP = 314, Width = 50.4, Draft = 19.4 },

                new Ship() { ShipType = ShipType.RoRo, DWT = 1000, Displacement = 1970, LengthOfAll = 66, LengthPP = 60, Width = 13.2, Draft = 3.2 },
                new Ship() { ShipType = ShipType.RoRo, DWT = 2000, Displacement = 3730, LengthOfAll = 85, LengthPP = 78, Width = 15.6, Draft = 4.1 },
                new Ship() { ShipType = ShipType.RoRo, DWT = 3000, Displacement = 5430, LengthOfAll = 99, LengthPP = 90, Width = 17.2, Draft = 4.8 },
                new Ship() { ShipType = ShipType.RoRo, DWT = 5000, Displacement = 8710, LengthOfAll = 119, LengthPP = 109, Width = 19.5, Draft = 5.8 },
                new Ship() { ShipType = ShipType.RoRo, DWT = 7000, Displacement = 11900, LengthOfAll = 135, LengthPP = 123, Width = 21.2, Draft = 6.6 },
                new Ship() { ShipType = ShipType.RoRo, DWT = 10000, Displacement = 16500, LengthOfAll = 153, LengthPP = 141, Width = 23.1, Draft = 7.5 },
                new Ship() { ShipType = ShipType.RoRo, DWT = 15000, Displacement = 24000, LengthOfAll = 178, LengthPP = 163, Width = 25.6, Draft = 8.7 },
                new Ship() { ShipType = ShipType.RoRo, DWT = 20000, Displacement = 31300, LengthOfAll = 198, LengthPP = 182, Width = 27.4, Draft = 9.7 },
                new Ship() { ShipType = ShipType.RoRo, DWT = 30000, Displacement = 45600, LengthOfAll = 229, LengthPP = 211, Width = 30.3, Draft = 11.3 },
            };
            Soils = new List<Soil>
            {
                new Soil() { SoilType = SoilType.Gravel, ros =2.85,  wn1 = 0.14, wn2 = 0.18, wn3 = 0.23, ro1 = 2.10, ro2 = 2.05, ro3 = 2.00},
                new Soil() { SoilType = SoilType.CroarseSand, ros =2.65, wn1 = 0.18, wn2 = 0.22, wn3 = 0.25, ro1 = 2.05, ro2 = 2.00, ro3 = 1.95},
                new Soil() { SoilType = SoilType.MediumSand, ros =2.65, wn1 = 0.18, wn2 = 0.22, wn3 = 0.25, ro1 = 2.05, ro2 = 2.00, ro3 = 1.95},
                new Soil() { SoilType = SoilType.FineSand, ros =2.65, wn1 = 0.22, wn2 = 0.24, wn3 = 0.28, ro1 = 2.00, ro2 = 1.90, ro3 = 1.85},
                new Soil() { SoilType = SoilType.DustySand, ros =2.65, wn1 = 0.22, wn2 = 0.24, wn3 = 0.28, ro1 = 2.00, ro2 = 1.90, ro3 = 1.85},
            };
            Profiles = new List<Profile>
            {
                new Profile() { ProfileType = ProfileType.R1400, Height = 1420, Thickness = 17.5, Area = 771, InertiaX = 1896156, ProfileShape = ProfileShape.Cycylindric },
                new Profile() { ProfileType = ProfileType.R1000, Height = 1016, Thickness = 30.0, Area = 929, InertiaX = 1130352, ProfileShape = ProfileShape.Cycylindric },
                new Profile() { ProfileType = ProfileType.R500, Height = 508.8, Thickness = 50.0, Area = 719, InertiaX = 190885, ProfileShape = ProfileShape.Cycylindric },
            };
            Steels = new List<Steel>
            {
                new Steel() { SteelType = SteelType.S235, YieldStrength = 235, YoungsModulus = 205 },
                new Steel() { SteelType = SteelType.S355, YieldStrength = 355, YoungsModulus = 205 },
            };
            Bollards = new List<Bollard>
            {
                new Bollard() { BollardType = BollardType.Tee, BearingCapacity = 15, Height = 235 },
                new Bollard() { BollardType = BollardType.Tee, BearingCapacity = 30, Height = 255 },
                new Bollard() { BollardType = BollardType.Tee, BearingCapacity = 50, Height = 350 },
                new Bollard() { BollardType = BollardType.Tee, BearingCapacity = 80, Height = 380 },
                new Bollard() { BollardType = BollardType.Tee, BearingCapacity = 100, Height = 410 },
                new Bollard() { BollardType = BollardType.Tee, BearingCapacity = 150, Height = 435 },
                new Bollard() { BollardType = BollardType.Tee, BearingCapacity = 200, Height = 500 },

                new Bollard() { BollardType = BollardType.Horn, BearingCapacity = 15, Height = 370 },
                new Bollard() { BollardType = BollardType.Horn, BearingCapacity = 30, Height = 410 },
                new Bollard() { BollardType = BollardType.Horn, BearingCapacity = 50, Height = 500 },
                new Bollard() { BollardType = BollardType.Horn, BearingCapacity = 80, Height = 520 },
                new Bollard() { BollardType = BollardType.Horn, BearingCapacity = 100, Height = 570 },
                new Bollard() { BollardType = BollardType.Horn, BearingCapacity = 150, Height = 585 },
                new Bollard() { BollardType = BollardType.Horn, BearingCapacity = 200, Height = 660 },

                new Bollard() { BollardType = BollardType.Kidney, BearingCapacity = 15, Height = 260 },
                new Bollard() { BollardType = BollardType.Kidney, BearingCapacity = 30, Height = 280 },
                new Bollard() { BollardType = BollardType.Kidney, BearingCapacity = 50, Height = 320 },
                new Bollard() { BollardType = BollardType.Kidney, BearingCapacity = 80, Height = 330 },
                new Bollard() { BollardType = BollardType.Kidney, BearingCapacity = 100, Height = 350 },
                new Bollard() { BollardType = BollardType.Kidney, BearingCapacity = 150, Height = 405 },
                new Bollard() { BollardType = BollardType.Kidney, BearingCapacity = 200, Height = 435 },
            };
        }


    }

    public enum ShipType { Cargo, BulkCarrier, Container, Tanker, RoRo, Passenger, Ferrie, Fisherman, LPG, LNG, Coaster }
    public enum SoilType { Gravel, CroarseSand, MediumSand, FineSand, DustySand }
    public enum ProfileType { R1400, R1000, R500, R200 }
    public enum ProfileShape { Cycylindric, Peine }
    public enum SteelType { S235, S355 }
    public enum BollardType { Tee, Horn, Kidney }

}
