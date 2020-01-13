using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using DolphinAnalyzer.Calculations;
using DolphinAnalyzer.Models;
using DolphinAnalyzer.Parameters;

namespace DolphinAnalyzer
{
    partial class MainWindow
    {
        private void calculateBollard()
        {
            var bollards = new Database().Bollards;
            if (BollardChoice.SelectedValue.ToString() == "Tee Bollard")
            {
                var b = bollards.FindAll(bollard => bollard.BollardType == BollardType.Tee);
                switch (BollardCapacityChoice.SelectedValue.ToString())
                {
                    case "15":
                    {
                        var b2 = b.First(bollard => bollard.BearingCapacity == 15);
                        BollardCalculations.BollardParametersCalc(b2);
                    }
                        break;
                    case "30":
                    {
                        var b2 = b.First(bollard => bollard.BearingCapacity == 30);
                        BollardCalculations.BollardParametersCalc(b2);
                    }
                        break;
                    case "50":
                    {
                        var b2 = b.First(bollard => bollard.BearingCapacity == 50);
                        BollardCalculations.BollardParametersCalc(b2);
                    }
                        break;
                    case "80":
                    {
                        var b2 = b.First(bollard => bollard.BearingCapacity == 80);
                        BollardCalculations.BollardParametersCalc(b2);
                    }
                        break;
                    case "100":
                    {
                        var b2 = b.First(bollard => bollard.BearingCapacity == 100);
                        BollardCalculations.BollardParametersCalc(b2);
                    }
                        break;
                    case "150":
                    {
                        var b2 = b.First(bollard => bollard.BearingCapacity == 150);
                        BollardCalculations.BollardParametersCalc(b2);
                    }
                        break;
                    case "200":
                    {
                        var b2 = b.First(bollard => bollard.BearingCapacity == 200);
                        BollardCalculations.BollardParametersCalc(b2);
                    }
                        break;
                }
            }
            else if (BollardChoice.SelectedValue.ToString() == "Horn Bollard")
            {
                var b = bollards.FindAll(bollard => bollard.BollardType == BollardType.Horn);
                if (BollardCapacityChoice.SelectedValue.ToString() == "15")
                {
                    var b2 = b.First(bollard => bollard.BearingCapacity == 15);
                    BollardCalculations.BollardParametersCalc(b2);
                }
                else if (BollardCapacityChoice.SelectedValue.ToString() == "30")
                {
                    var b2 = b.First(bollard => bollard.BearingCapacity == 30);
                    BollardCalculations.BollardParametersCalc(b2);
                }
                else if (BollardCapacityChoice.SelectedValue.ToString() == "50")
                {
                    var b2 = b.First(bollard => bollard.BearingCapacity == 50);
                    BollardCalculations.BollardParametersCalc(b2);
                }
                else if (BollardCapacityChoice.SelectedValue.ToString() == "80")
                {
                    var b2 = b.First(bollard => bollard.BearingCapacity == 80);
                    BollardCalculations.BollardParametersCalc(b2);
                }
                else if (BollardCapacityChoice.SelectedValue.ToString() == "100")
                {
                    var b2 = b.First(bollard => bollard.BearingCapacity == 100);
                    BollardCalculations.BollardParametersCalc(b2);
                }
                else if (BollardCapacityChoice.SelectedValue.ToString() == "150")
                {
                    var b2 = b.First(bollard => bollard.BearingCapacity == 150);
                    BollardCalculations.BollardParametersCalc(b2);
                }
                else if (BollardCapacityChoice.SelectedValue.ToString() == "200")
                {
                    var b2 = b.First(bollard => bollard.BearingCapacity == 200);
                    BollardCalculations.BollardParametersCalc(b2);
                }
            }
            else if (BollardChoice.SelectedValue.ToString() == "Kidney Bollard")
            {
                var b = bollards.FindAll(bollard => bollard.BollardType == BollardType.Kidney);
                if (BollardCapacityChoice.SelectedValue.ToString() == "15")
                {
                    var b2 = b.First(bollard => bollard.BearingCapacity == 15);
                    BollardCalculations.BollardParametersCalc(b2);
                }
                else if (BollardCapacityChoice.SelectedValue.ToString() == "30")
                {
                    var b2 = b.First(bollard => bollard.BearingCapacity == 30);
                    BollardCalculations.BollardParametersCalc(b2);
                }
                else if (BollardCapacityChoice.SelectedValue.ToString() == "50")
                {
                    var b2 = b.First(bollard => bollard.BearingCapacity == 50);
                    BollardCalculations.BollardParametersCalc(b2);
                }
                else if (BollardCapacityChoice.SelectedValue.ToString() == "80")
                {
                    var b2 = b.First(bollard => bollard.BearingCapacity == 80);
                    BollardCalculations.BollardParametersCalc(b2);
                }
                else if (BollardCapacityChoice.SelectedValue.ToString() == "100")
                {
                    var b2 = b.First(bollard => bollard.BearingCapacity == 100);
                    BollardCalculations.BollardParametersCalc(b2);
                }
                else if (BollardCapacityChoice.SelectedValue.ToString() == "150")
                {
                    var b2 = b.First(bollard => bollard.BearingCapacity == 150);
                    BollardCalculations.BollardParametersCalc(b2);
                }
                else if (BollardCapacityChoice.SelectedValue.ToString() == "200")
                {
                    var b2 = b.First(bollard => bollard.BearingCapacity == 200);
                    BollardCalculations.BollardParametersCalc(b2);
                }
            }

            

        }

        private void BollardChoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(BollardCapacityChoice==null || HBLabel==null || BollardImage==null) return;

            calculateBollard();
            HBLabel.Content = MooringParameters.BollardHeight.ToString();

            if (BollardChoice.SelectedValue.ToString() == "Tee Bollard")
            {
                BollardImage.Source = new BitmapImage(new Uri(@"images\Tee.jpg", UriKind.Relative));
            }
            else if (BollardChoice.SelectedValue.ToString() == "Horn Bollard")
            {
                BollardImage.Source = new BitmapImage(new Uri(@"images\Horn.jpg", UriKind.Relative));
            }
            else if (BollardChoice.SelectedValue.ToString() == "Kidney Bollard")
            {
                BollardImage.Source = new BitmapImage(new Uri(@"images\Kidney.jpg", UriKind.Relative));
            }
        }
        private void BollardCapacityChoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BollardCapacityChoice == null || HBLabel == null || BollardImage == null) return;


            calculateBollard();
            HBLabel.Content = MooringParameters.BollardHeight.ToString();

            if (BollardChoice.SelectedValue.ToString() == "Tee Bollard")
            {
                BollardImage.Source = new BitmapImage(new Uri(@"images\Tee.jpg", UriKind.Relative));
            }
            else if (BollardChoice.SelectedValue.ToString() == "Horn Bollard")
            {
                BollardImage.Source = new BitmapImage(new Uri(@"images\Horn.jpg", UriKind.Relative));
            }
            else if (BollardChoice.SelectedValue.ToString() == "Kidney Bollard")
            {
                BollardImage.Source = new BitmapImage(new Uri(@"images\Kidney.jpg", UriKind.Relative));
            }
        }
        private void SetBollard_Click(object sender, RoutedEventArgs e)
        {
            calculateBollard();
            HBLabel.Content = MooringParameters.BollardHeight.ToString();
        }
        private void BollardChoice_Initialized(object sender, EventArgs e)
        {
            BollardChoice.Items.Add("Tee Bollard");
            BollardChoice.Items.Add("Horn Bollard");
            BollardChoice.Items.Add("Kidney Bollard");
        }
        private void BollardCapacityChoice_Initialized(object sender, EventArgs e)
        {
            BollardCapacityChoice.Items.Add("15");
            BollardCapacityChoice.Items.Add("30");
            BollardCapacityChoice.Items.Add("50");
            BollardCapacityChoice.Items.Add("80");
            BollardCapacityChoice.Items.Add("100");
            BollardCapacityChoice.Items.Add("150");
            BollardCapacityChoice.Items.Add("200");
        }
    }
}
