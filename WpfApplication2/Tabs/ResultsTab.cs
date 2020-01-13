using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DolphinAnalyzer.Calculations;

namespace DolphinAnalyzer
{
    partial class MainWindow
    {
        private void Label_Initialized(object sender, EventArgs e)
        {
            double fb = 1;

            GetSafetyCoefficient.Text = fb.ToString();

            FenderFunction.FunctionStabilityCondition(fb);
            MooringFunction.StressCondition();
            UpdateResults();
        }

        private void GetSafetyCoefficient_TextChanged(object sender, TextChangedEventArgs e)
        {
            double fb = Convert.ToDouble(GetSafetyCoefficient.Text);

            FenderFunction.FunctionStabilityCondition(fb);
            MooringFunction.StressCondition();
            UpdateResults();
        }

        private void UpdateResults()
        {
            _1condition.Content = Results.StabilityCondition.ToString();
            _2condition.Content = Results.StressCondition1.ToString();
            _3condition.Content = Results.StressCondition2.ToString();

        }
        private void UpButton1_Click(object sender, RoutedEventArgs e)
        {
            if (GetSafetyCoefficient.Text.IsNumeric())
            {
                double fb = Convert.ToDouble(GetSafetyCoefficient.Text);
                fb = fb + 0.1;
                GetSafetyCoefficient.Text = fb.ToString();
            }

        }
        private void DownButton1_Click(object sender, RoutedEventArgs e)
        {
            if (GetSafetyCoefficient.Text.IsNumeric())
            {
                double fb = Convert.ToDouble(GetSafetyCoefficient.Text);
                fb = fb - 0.1;
                GetSafetyCoefficient.Text = fb.ToString();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MooringFunction.UseAll();

            ResultsWindow okno = new ResultsWindow();
            okno.ShowDialog();
        }


    }
}
