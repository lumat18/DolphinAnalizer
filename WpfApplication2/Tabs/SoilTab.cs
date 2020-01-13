using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DolphinAnalyzer
{
    partial class MainWindow
    {
        private void SoilChoice_Initialized(object sender, EventArgs e)
        {
            SoilChoice.Items.Add("Żwir");
            SoilChoice.Items.Add("Piasek drobny");
            SoilChoice.Items.Add("Piasek średni");
            SoilChoice.Items.Add("Piasek gruby");
            SoilChoice.Items.Add("Piasek pylasty");
        }

        private void calculateSoil()
        {
            var degree = Convert.ToDouble(SoilDegree.Text);
            if (degree >= 1)
            {
                MessageBox.Show("Błędna wartość! Id < 1!", "Uwaga!");
                SoilDegree.Text = "";
                return;
            }
            var soils = new Database().Soils;
            if (SoilChoice.SelectedValue.ToString() == "Żwir")
            {
                var s = soils.First(soil => soil.SoilType == SoilType.Gravel);
                SoilCalculations.SoilParametersCalc(s, degree);
            }
            else if (SoilChoice.SelectedValue.ToString() == "Piasek gruby")
            {
                var s = soils.First(soil => soil.SoilType == SoilType.CroarseSand);
                SoilCalculations.SoilParametersCalc(s, degree);
            }
            else if (SoilChoice.SelectedValue.ToString() == "Piasek średni")
            {
                var s = soils.First(soil => soil.SoilType == SoilType.MediumSand);
                SoilCalculations.SoilParametersCalc(s, degree);
            }
            else if (SoilChoice.SelectedValue.ToString() == "Piasek drobny")
            {
                var s = soils.First(soil => soil.SoilType == SoilType.FineSand);
                SoilCalculations.SoilParametersCalc(s, degree);
            }
            else if (SoilChoice.SelectedValue.ToString() == "Piasek pylasty")
            {
                var s = soils.First(soil => soil.SoilType == SoilType.DustySand);
                SoilCalculations.SoilParametersCalc(s, degree);
            }
        }
        private void SoilChoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SoilDegree.Text.IsNumeric())
            {
                calculateSoil();
                UpdateSoilParameters();
            }
        }
        private void SoilDegree_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SoilDegree.Text.IsNumeric())
            {
                calculateSoil();
                UpdateSoilParameters();
            }
        }

        private void UpdateSoilParameters()
        {
            FILabel.Content = SoilParameters.AngleOfSelfFriction.ToString();
            DELTALabel1.Content = SoilParameters.AngleOfWallFriction.ToString();
            GAMMAPLabel.Content = SoilParameters.SaturatedVolumeWeight.ToString();
            NLabel.Content = SoilParameters.Porosity.ToString();
            ROSLabel.Content = SoilParameters.DensityOfSoilSkeleton.ToString();
            ROLabel.Content = SoilParameters.SoilDensity.ToString();
            KPHLabel.Content = SoilParameters.CoefficientOfPassivePressure.ToString();
            FGLabel.Content = SoilParameters.SoilCoefficient.ToString();
        }
    }
}
