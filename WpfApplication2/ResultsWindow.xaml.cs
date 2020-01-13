using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DolphinAnalyzer.Parameters;

namespace DolphinAnalyzer
{
    /// <summary>
    /// Interaction logic for ResultsWindow.xaml
    /// </summary>
    public partial class ResultsWindow : Window
    {
        public ResultsWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ResultD.Content = ShipParameters.DWT.ToString();
            ResultM.Content = ShipParameters.M.ToString();
            ResultLc.Content = ShipParameters.Lcc.ToString();
            ResultLpp.Content = ShipParameters.Lpp.ToString();
            ResultBc.Content = ShipParameters.Bc.ToString();
            ResultTc.Content = ShipParameters.Tc.ToString();

            ResultSoilType.Content = SoilParameters.SoilType.ToString();
            ResultId.Content = SoilParameters.DegreeOfCompaction.ToString();
            ResultRo.Content = SoilParameters.SoilDensity.ToString();
            ResultRos.Content = SoilParameters.DensityOfSoilSkeleton.ToString();
            ResultGammap.Content = SoilParameters.SaturatedVolumeWeight.ToString();
            ResultFi.Content = SoilParameters.AngleOfSelfFriction.ToString();
            ResultDelta.Content = SoilParameters.AngleOfWallFriction.ToString();
            ResultN.Content = SoilParameters.Porosity.ToString();
            ResultKph.Content = SoilParameters.CoefficientOfPassivePressure.ToString();
            ResultFg.Content = SoilParameters.SoilCoefficient.ToString();

            ResultRt.Content = ApproachParameters.DepthMargin.ToString();
            ResultV.Content = ApproachParameters.Velocity.ToString();
            ResultAlfap.Content = ApproachParameters.Angle.ToString();
            ResultCe.Content = ApproachParameters.EccentricityCoefficient.ToString();
            ResultCm.Content = ApproachParameters.AddedMassCoefficient.ToString();
            ResultCs.Content = ApproachParameters.SoftnessCoefficient.ToString();

            ResultB.Content = GeometryParameters.ConstructionWidth.ToString();
            ResultHc.Content = GeometryParameters.CapHeight.ToString();
            ResultHd.Content = GeometryParameters.SpaceUnder.ToString();
            ResultHp.Content = GeometryParameters.ForceHeight.ToString();

            ResultProfileType.Content = GeometryParameters.ProfileType.ToString();
            ResultSteelType.Content = GeometryParameters.SteelType.ToString();

            Resulta.Content = GeometryParameters.HorizontalAmount.ToString();
            Resultb.Content = GeometryParameters.VertiaclAmount.ToString();
            ResultX.Content = GeometryParameters.HorizontalSpacing.ToString();
            ResultY.Content = GeometryParameters.VertiaclSpacing.ToString();

            ResultWx.Content = GeometryParameters.GlobalModulusX.ToString();
            ResultWy.Content = GeometryParameters.GlobalModulusY.ToString();
            ResultIx.Content = GeometryParameters.GlobalInetriaX.ToString();
            ResultIy.Content = GeometryParameters.GlobalInertiaY.ToString();

            ResultMmaxodb.Content = GeometryParameters.MaximumMoment.ToString();
            ResultXmodb.Content = GeometryParameters.MomentDepth.ToString();
            ResultT0.Content = GeometryParameters.DolphinDepth.ToString();
            ResultP.Content = Results.MaximalForce.ToString();
            //Resultd.Content = Results.Deflection.ToString();
            ResultEp.Content = Results.PotentialEnergyOfElasticDeflection.ToString();
            ResultEk.Content = Results.BerthingEnergy.ToString();

            ResultBollardType.Content = MooringParameters.BollardType.ToString();
            ResultHz.Content = MooringParameters.ForceHeight.ToString();
            ResultXmcum.Content = MooringParameters.MomentDepth.ToString();
            ResultMmaxcum.Content = MooringParameters.MaximumMoment.ToString();
            ResultAlfaM.Content = MooringParameters.MooringAngleAlfa.ToString();
            ResultSP1.Content = MooringParameters.StressP1.ToString();
            ResultSP2.Content = MooringParameters.StressP2.ToString();
        }
    }
}
