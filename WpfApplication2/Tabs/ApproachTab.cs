using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DolphinAnalyzer.Tabs;

namespace DolphinAnalyzer
{
    partial class MainWindow
    {
        private void calculateApproach()
        {
            double alfa = Convert.ToDouble(Angle.Text);
            double margin = Convert.ToDouble(DepthMargin.Text);
            double velocity = Convert.ToDouble(Velocity.Text);

            ApproachParameters.Angle = alfa;
            ApproachParameters.DepthMargin = margin;
            ApproachParameters.Velocity = velocity;

            double point = ShipParameters.Lpp/4;
            string formula = "PIANC";

            if (RadioButtonCe1.IsChecked == true)
            {
                point = ShipParameters.Lpp/4;
            }
            else if (RadioButtonCe2.IsChecked == true)
            {
                point = ShipParameters.Lpp/3;
            }
            else if (RadioButtonCe3.IsChecked == true)
            {
                point = ShipParameters.Lpp/2;
            }

            if (RadioButtonCm1.IsChecked == true)
            {
                formula = "PIANC";
            }
            else if (RadioButtonCm2.IsChecked == true)
            {
                formula = "Ueda";
            }
            else if (RadioButtonCm3.IsChecked == true)
            {
                formula = "Vasco Costa";
            }

            if (RadioButtonCs1.IsChecked == true)
            {
                ApproachParameters.SoftnessCoefficient = 1;
            }
            else if (RadioButtonCs2.IsChecked == true)
            {
                ApproachParameters.SoftnessCoefficient = 0.9;
            }
            ApproachCalculations.ApproachParametersCalc(alfa,point,formula,margin);
        }
        private void DepthMargin_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (DepthMargin.Text.IsNumeric())
            {
                if (Velocity.Text.IsNumeric())
                {
                    if (Angle.Text.IsNumeric())
                    {
                        calculateApproach();
                        UpdateApproachParameters(); 
                    }
                }

            }
        }
        private void Velocity_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (DepthMargin.Text.IsNumeric())
            {
                if (Velocity.Text.IsNumeric())
                {
                    if (Angle.Text.IsNumeric())
                    {
                        calculateApproach();
                        UpdateApproachParameters();
                    }
                }

            }
        }
        private void Angle_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (DepthMargin.Text.IsNumeric())
            {
                if (Velocity.Text.IsNumeric())
                {
                    if (Angle.Text.IsNumeric())
                    {
                        calculateApproach();
                        UpdateApproachParameters();
                    }
                }

            }
        }
        private void RadioButtonCe1_Click(object sender, RoutedEventArgs e)
        {
            if (DepthMargin.Text.IsNumeric())
            {
                if (Velocity.Text.IsNumeric())
                {
                    if (Angle.Text.IsNumeric())
                    {
                        calculateApproach();
                        UpdateApproachParameters();
                    }
                }

            }
        }
        private void RadioButtonCe2_Click(object sender, RoutedEventArgs e)
        {
            if (DepthMargin.Text.IsNumeric())
            {
                if (Velocity.Text.IsNumeric())
                {
                    if (Angle.Text.IsNumeric())
                    {
                        calculateApproach();
                        UpdateApproachParameters();
                    }
                }

            }
        }
        private void RadioButtonCe3_Click(object sender, RoutedEventArgs e)
        {
            if (DepthMargin.Text.IsNumeric())
            {
                if (Velocity.Text.IsNumeric())
                {
                    if (Angle.Text.IsNumeric())
                    {
                        calculateApproach();
                        UpdateApproachParameters();
                    }
                }

            }
        }
        private void RadioButtonCm1_Click(object sender, RoutedEventArgs e)
        {
            if (DepthMargin.Text.IsNumeric())
            {
                if (Velocity.Text.IsNumeric())
                {
                    if (Angle.Text.IsNumeric())
                    {
                        calculateApproach();
                        UpdateApproachParameters();
                    }
                }

            }
        }
        private void RadioButtonCm2_Click(object sender, RoutedEventArgs e)
        {
            if (DepthMargin.Text.IsNumeric())
            {
                if (Velocity.Text.IsNumeric())
                {
                    if (Angle.Text.IsNumeric())
                    {
                        calculateApproach();
                        UpdateApproachParameters();
                    }
                }

            }
        }
        private void RadioButtonCm3_Click(object sender, RoutedEventArgs e)
        {
            if (DepthMargin.Text.IsNumeric())
            {
                if (Velocity.Text.IsNumeric())
                {
                    if (Angle.Text.IsNumeric())
                    {
                        calculateApproach();
                        UpdateApproachParameters();
                    }
                }

            }
        }
        private void RadioButtonCs1_Click(object sender, RoutedEventArgs e)
        {
            if (DepthMargin.Text.IsNumeric())
            {
                if (Velocity.Text.IsNumeric())
                {
                    if (Angle.Text.IsNumeric())
                    {
                        calculateApproach();
                        UpdateApproachParameters();
                    }
                }

            }
        }
        private void RadioButtonCs2_Click(object sender, RoutedEventArgs e)
        {
            if (DepthMargin.Text.IsNumeric())
            {
                if (Velocity.Text.IsNumeric())
                {
                    if (Angle.Text.IsNumeric())
                    {
                        calculateApproach();
                        UpdateApproachParameters();
                    }
                }

            }
        }

        private void UpdateApproachParameters()
        {
            CELabel.Content = ApproachParameters.EccentricityCoefficient.ToString();
            CMLabel.Content = ApproachParameters.AddedMassCoefficient.ToString();
            CSLabel.Content = ApproachParameters.SoftnessCoefficient.ToString();
            RLabel.Content = ApproachParameters.Radius.ToString();
            KLabel.Content = ApproachParameters.RadiusOfGyration.ToString();
        }
    }
}
