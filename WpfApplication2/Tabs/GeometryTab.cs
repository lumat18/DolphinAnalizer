using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DolphinAnalyzer.Calculations;
using DolphinAnalyzer.Models;
using DolphinAnalyzer.Parameters;

namespace DolphinAnalyzer
{
    partial class MainWindow
    {
        private void calculateGeometry()
        {
            double B = Convert.ToDouble(ConstructionWidth.Text);
            double Hc = Convert.ToDouble(CapHeight.Text);
            double Hd = Convert.ToDouble(SpaceUnder.Text);

            GeometryParameters.ConstructionWidth = B;
            GeometryParameters.CapHeight = Hc;
            GeometryParameters.SpaceUnder = Hd;

            double a = Convert.ToDouble(GetA.Text);
            double x = Convert.ToDouble(GetX.Text);
            double b = Convert.ToDouble(GetB.Text);
            double y = Convert.ToDouble(GetY.Text);

            var profiles = new Database().Profiles;
            var steels = new Database().Steels;
            if (ProfileChoice.SelectedValue.ToString() == "R1400")
            {
                var p = profiles.First(profile => profile.ProfileType == ProfileType.R1400);
                if (SteelChoice.SelectedValue.ToString() == "S235")
                {
                    var s = steels.First(steel => steel.SteelType == SteelType.S235);
                    GeometryCalculations.GeometryParametersCalc(p,s,x,y,a,b);
                }
                else if (SteelChoice.SelectedValue.ToString() == "S355")
                {
                    var s = steels.First(steel => steel.SteelType == SteelType.S355);
                    GeometryCalculations.GeometryParametersCalc(p,s,x,y,a,b);
                }
            }
            else if (ProfileChoice.SelectedValue.ToString() == "R1000")
            {
                var p = profiles.First(profile => profile.ProfileType == ProfileType.R1000);
                if (SteelChoice.SelectedValue.ToString() == "S235")
                {
                    var s = steels.First(steel => steel.SteelType == SteelType.S235);
                    GeometryCalculations.GeometryParametersCalc(p, s, x, y, a, b);
                }
                else if (SteelChoice.SelectedValue.ToString() == "S355")
                {
                    var s = steels.First(steel => steel.SteelType == SteelType.S355);
                    GeometryCalculations.GeometryParametersCalc(p, s, x, y, a, b);
                }
            }
            else if (ProfileChoice.SelectedValue.ToString() == "R500")
            {
                var p = profiles.First(profile => profile.ProfileType == ProfileType.R500);
                if (SteelChoice.SelectedValue.ToString() == "S235")
                {
                    var s = steels.First(steel => steel.SteelType == SteelType.S235);
                    GeometryCalculations.GeometryParametersCalc(p, s, x, y, a, b);
                }
                else if (SteelChoice.SelectedValue.ToString() == "S355")
                {
                    var s = steels.First(steel => steel.SteelType == SteelType.S355);
                    GeometryCalculations.GeometryParametersCalc(p, s, x, y, a, b);
                }
            }
        }
        private void ProfileChoice_Initialized(object sender, EventArgs e)
        {
            ProfileChoice.Items.Add("R1400");
            ProfileChoice.Items.Add("R1000");
            ProfileChoice.Items.Add("R500");
        }
        private void SteelChoice_Initialized(object sender, EventArgs e)
        {
            SteelChoice.Items.Add("S235");
            SteelChoice.Items.Add("S355");
        }

        private void UpdateGeometryParameters()
        {
            HDOPLabel.Content = GeometryParameters.LimitDepth.Round2Str();
            HPLabel.Content = GeometryParameters.ForceHeight.Round2Str();
            T0Label.Content = GeometryParameters.DolphinDepth.Round2Str();
        }

        private void ConstructionWidth_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ConstructionWidth.Text.IsNumeric())
            {
                if (CapHeight.Text.IsNumeric())
                {
                    if (SpaceUnder.Text.IsNumeric())
                    {
                        if (GetA.Text.IsNumeric())
                        {
                            if (GetB.Text.IsNumeric())
                            {
                                if (GetX.Text.IsNumeric())
                                {
                                    if (GetY.Text.IsNumeric())
                                    {
                                        calculateGeometry();
                                        UpdateGeometryParameters();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void CapHeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ConstructionWidth.Text.IsNumeric())
            {
                if (CapHeight.Text.IsNumeric())
                {
                    if (SpaceUnder.Text.IsNumeric())
                    {
                        if (GetA.Text.IsNumeric())
                        {
                            if (GetB.Text.IsNumeric())
                            {
                                if (GetX.Text.IsNumeric())
                                {
                                    if (GetY.Text.IsNumeric())
                                    {
                                        calculateGeometry();
                                        UpdateGeometryParameters();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void SpaceUnder_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ConstructionWidth.Text.IsNumeric())
            {
                if (CapHeight.Text.IsNumeric())
                {
                    if (SpaceUnder.Text.IsNumeric())
                    {
                        if (GetA.Text.IsNumeric())
                        {
                            if (GetB.Text.IsNumeric())
                            {
                                if (GetX.Text.IsNumeric())
                                {
                                    if (GetY.Text.IsNumeric())
                                    {
                                        calculateGeometry();
                                        UpdateGeometryParameters();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void ProfileChoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ConstructionWidth.Text.IsNumeric())
            {
                if (CapHeight.Text.IsNumeric())
                {
                    if (SpaceUnder.Text.IsNumeric())
                    {
                        if (GetA.Text.IsNumeric())
                        {
                            if (GetB.Text.IsNumeric())
                            {
                                if (GetX.Text.IsNumeric())
                                {
                                    if (GetY.Text.IsNumeric())
                                    {
                                        calculateGeometry();
                                        UpdateGeometryParameters();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void SteelChoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ConstructionWidth.Text.IsNumeric())
            {
                if (CapHeight.Text.IsNumeric())
                {
                    if (SpaceUnder.Text.IsNumeric())
                    {
                        if (GetA.Text.IsNumeric())
                        {
                            if (GetB.Text.IsNumeric())
                            {
                                if (GetX.Text.IsNumeric())
                                {
                                    if (GetY.Text.IsNumeric())
                                    {
                                        calculateGeometry();
                                        UpdateGeometryParameters();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void GetA_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ConstructionWidth.Text.IsNumeric())
            {
                if (CapHeight.Text.IsNumeric())
                {
                    if (SpaceUnder.Text.IsNumeric())
                    {
                        if (GetA.Text.IsNumeric())
                        {
                            if (GetB.Text.IsNumeric())
                            {
                                if (GetX.Text.IsNumeric())
                                {
                                    if (GetY.Text.IsNumeric())
                                    {
                                        calculateGeometry();
                                        UpdateGeometryParameters();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void GetX_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ConstructionWidth.Text.IsNumeric())
            {
                if (CapHeight.Text.IsNumeric())
                {
                    if (SpaceUnder.Text.IsNumeric())
                    {
                        if (GetA.Text.IsNumeric())
                        {
                            if (GetB.Text.IsNumeric())
                            {
                                if (GetX.Text.IsNumeric())
                                {
                                    if (GetY.Text.IsNumeric())
                                    {
                                        calculateGeometry();
                                        UpdateGeometryParameters();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void GetB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ConstructionWidth.Text.IsNumeric())
            {
                if (CapHeight.Text.IsNumeric())
                {
                    if (SpaceUnder.Text.IsNumeric())
                    {
                        if (GetA.Text.IsNumeric())
                        {
                            if (GetB.Text.IsNumeric())
                            {
                                if (GetX.Text.IsNumeric())
                                {
                                    if (GetY.Text.IsNumeric())
                                    {
                                        calculateGeometry();
                                        UpdateGeometryParameters();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void GetY_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ConstructionWidth.Text.IsNumeric() && CapHeight.Text.IsNumeric() && SpaceUnder.Text.IsNumeric() &&
                GetA.Text.IsNumeric() && GetB.Text.IsNumeric() && GetX.Text.IsNumeric() && GetY.Text.IsNumeric())
            {
                calculateGeometry();
                UpdateGeometryParameters();
            }

            drawPiles();
        }

        private void drawPiles()
        {
            PilesDiagram.Children.Clear();
            int a = int.Parse(GetA.Text);
            a += 2;
            double x = double.Parse(GetX.Text);
            x *= 1000;
            int b = int.Parse(GetB.Text);
            b += 2;
            double y = double.Parse(GetY.Text);
            y *= 1000;
            Profile profile = new Database().Profiles.First(p => p.ProfileType == GeometryParameters.ProfileType);
            double diameter = profile.Height;
            double thickness = profile.Thickness;

            double rightmost = (a - 1)*x + diameter;
            double bottommost = (b - 1)*y + diameter;
            double maxmost = Math.Max(rightmost, bottommost);

            double f = PilesDiagram.Width / maxmost;


            double offsetY=0, offsetX = 0;

            if (rightmost > bottommost)
            {
                offsetY = rightmost / 2 - bottommost / 2;
                
            }
            else
            {
                offsetX = bottommost / 2 - rightmost / 2;
            }


            for(int i=1;i<a-1;i++)//w prawo
            {
                for (int j = 1; j < b-1; j++)//w dół
                {
                    var ellipse = CreatePile(diameter*f, diameter*f, thickness*f*10, i*x*f+offsetX*f, j*y*f+offsetY*f);
                    PilesDiagram.Children.Add(ellipse);
                }
            }

            
        }

        private Ellipse CreatePile(double w, double h, double thickness, double left, double top)
        {
            Ellipse ellipse = new Ellipse()
            {
                Fill = new SolidColorBrush(Colors.Transparent),
                Width = w,
                Height = h,
                Stroke = new SolidColorBrush(Colors.Green),
                StrokeThickness = thickness,
                Margin = new Thickness(left, top, 0, 0)
            };
            return ellipse;
        }
    }
}
