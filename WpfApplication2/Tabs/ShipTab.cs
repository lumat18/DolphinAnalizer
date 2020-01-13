using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DolphinAnalyzer
{
    partial class MainWindow
    {

        private void TypeOfShip_Initialized(object sender, EventArgs e)
        {
            TypeOfShip.Items.Add("Drobnicowiec");           // Cargo
            TypeOfShip.Items.Add("Masowiec");               // BulkCarrier
            TypeOfShip.Items.Add("Kontenerowiec");          // Container
            TypeOfShip.Items.Add("Zbiornikowiec");          // Tanker
            TypeOfShip.Items.Add("Gazowiec LNG");           // LNG
            TypeOfShip.Items.Add("Gazowiec LPG");           // LPG
            TypeOfShip.Items.Add("Statek pasażerski");      // Passenger
            TypeOfShip.Items.Add("Statek Ro-Ro");           // RoRo
            TypeOfShip.Items.Add("Kabotażowiec");           // Coaster
            TypeOfShip.Items.Add("Prom");                   // Ferrie
            TypeOfShip.Items.Add("Statek rybacki");         // Fisherman
        }

        private void calculateShip()
        {
            var size = Convert.ToDouble(ShipLabel.Text);
            var ships = new Database().Ships;
            if (RadioButtonShip1.IsChecked==true)
            {
                if (TypeOfShip.SelectedValue.ToString() == "Zbiornikowiec")
                {
                    var tanker = ships.FindAll(ship => ship.ShipType == ShipType.Tanker);
                    if (size < tanker.First().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    if (size > tanker.Last().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);

                    
                    var wiekszy = tanker.First(ship => ship.DWT > size);
                    var mniejszy = tanker.Last(ship => ship.DWT < size);


                    Utils.InterpolateDWT( size, wiekszy, mniejszy );
                    UpdateLabals();

                }
                else if (TypeOfShip.SelectedValue.ToString() == "Gazowiec LNG")
                {
                    var lng = ships.FindAll(ship => ship.ShipType == ShipType.LNG);
                    if (size < lng.First().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    if (size > lng.Last().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                    var wiekszy = lng.First(ship => ship.DWT > size);
                    var mniejszy = lng.Last(ship => ship.DWT < size);


                    Utils.InterpolateDWT(size, wiekszy, mniejszy);
                    UpdateLabals();
                }
                else if (TypeOfShip.SelectedValue.ToString() == "Gazowiec LPG")
                {
                    var lpg = ships.FindAll(ship => ship.ShipType == ShipType.LPG);
                    if (size < lpg.First().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    if (size > lpg.Last().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                    var wiekszy = lpg.First(ship => ship.DWT > size);
                    var mniejszy = lpg.Last(ship => ship.DWT < size);


                    Utils.InterpolateDWT(size, wiekszy, mniejszy);
                    UpdateLabals();
                }
                else if (TypeOfShip.SelectedValue.ToString() == "Kontenerowiec")
                {
                    var container = ships.FindAll(ship => ship.ShipType == ShipType.Container);
                    if (size < container.First().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    if (size > container.Last().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                    var wiekszy = container.First(ship => ship.DWT > size);
                    var mniejszy = container.Last(ship => ship.DWT < size);


                    Utils.InterpolateDWT(size, wiekszy, mniejszy);
                    UpdateLabals();
                }
                else if (TypeOfShip.SelectedValue.ToString() == "Statek Ro-Ro")
                {
                    var roro = ships.FindAll(ship => ship.ShipType == ShipType.RoRo);
                    if (size < roro.First().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    if (size > roro.Last().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                    var wiekszy = roro.First(ship => ship.DWT > size);
                    var mniejszy = roro.Last(ship => ship.DWT < size);


                    Utils.InterpolateDWT(size, wiekszy, mniejszy);
                    UpdateLabals();
                }
                else if (TypeOfShip.SelectedValue.ToString() == "Prom")
                {
                    var ferrie = ships.FindAll(ship => ship.ShipType == ShipType.Ferrie);
                    if (size < ferrie.First().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    if (size > ferrie.Last().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                    var wiekszy = ferrie.First(ship => ship.DWT > size);
                    var mniejszy = ferrie.Last(ship => ship.DWT < size);


                    Utils.InterpolateDWT(size, wiekszy, mniejszy);
                    UpdateLabals();
                }
                else if (TypeOfShip.SelectedValue.ToString() == "Statek pasażerski")
                {
                    var passenger = ships.FindAll(ship => ship.ShipType == ShipType.Passenger);
                    if (size < passenger.First().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    if (size > passenger.Last().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                    var wiekszy = passenger.First(ship => ship.DWT > size);
                    var mniejszy = passenger.Last(ship => ship.DWT < size);


                    Utils.InterpolateDWT(size, wiekszy, mniejszy);
                    UpdateLabals();
                }
                else if (TypeOfShip.SelectedValue.ToString() == "Kabotażowiec")
                {
                    var coaster = ships.FindAll(ship => ship.ShipType == ShipType.Coaster);
                    if (size < coaster.First().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    if (size > coaster.Last().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                    var wiekszy = coaster.First(ship => ship.DWT > size);
                    var mniejszy = coaster.Last(ship => ship.DWT < size);


                    Utils.InterpolateDWT(size, wiekszy, mniejszy);
                    UpdateLabals();
                }
                else if (TypeOfShip.SelectedValue.ToString() == "Statek rybacki")
                {
                    var fisherman = ships.FindAll(ship => ship.ShipType == ShipType.Fisherman);
                    if (size < fisherman.First().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    if (size > fisherman.Last().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                    var wiekszy = fisherman.First(ship => ship.DWT > size);
                    var mniejszy = fisherman.Last(ship => ship.DWT < size);


                    Utils.InterpolateDWT(size, wiekszy, mniejszy);
                    UpdateLabals();
                }
                else if (TypeOfShip.SelectedValue.ToString() == "Masowiec")
                {
                    var bulk = ships.FindAll(ship => ship.ShipType == ShipType.BulkCarrier);
                    if (size < bulk.First().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    if (size > bulk.Last().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                    var wiekszy = bulk.First(ship => ship.DWT > size);
                    var mniejszy = bulk.Last(ship => ship.DWT < size);


                    Utils.InterpolateDWT(size, wiekszy, mniejszy);
                    UpdateLabals();
                }
                else if (TypeOfShip.SelectedValue.ToString() == "Drobnicowiec")
                {
                    var cargo = ships.FindAll(ship => ship.ShipType == ShipType.Cargo);
                    if (size < cargo.First().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    if (size > cargo.Last().DWT)
                    {
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        return;
                    }
                    ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                    var wiekszy = cargo.First(ship => ship.DWT > size);
                    var mniejszy = cargo.Last(ship => ship.DWT < size);


                    Utils.InterpolateDWT(size, wiekszy, mniejszy);
                    UpdateLabals();
                }
            }
            else if (RadioButtonShip2.IsChecked == true)
            {
                {
                    if (TypeOfShip.SelectedValue.ToString() == "Zbiornikowiec")
                    {
                        var tanker = ships.FindAll(ship => ship.ShipType == ShipType.Tanker);
                        if (size < tanker.First().Displacement)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        if (size > tanker.Last().Displacement)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                        var wiekszy = tanker.First(ship => ship.Displacement > size);
                        var mniejszy = tanker.Last(ship => ship.Displacement < size);


                        Utils.InterpolateDisplacement(size, wiekszy, mniejszy);
                        UpdateLabals();

                    }
                    else if (TypeOfShip.SelectedValue.ToString() == "Gazowiec LNG")
                    {
                        var lng = ships.FindAll(ship => ship.ShipType == ShipType.LNG);
                        if (size < lng.First().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        if (size > lng.Last().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                        var wiekszy = lng.First(ship => ship.DWT > size);
                        var mniejszy = lng.Last(ship => ship.DWT < size);


                        Utils.InterpolateDisplacement(size, wiekszy, mniejszy);
                        UpdateLabals();
                    }
                    else if (TypeOfShip.SelectedValue.ToString() == "Gazowiec LPG")
                    {
                        var lpg = ships.FindAll(ship => ship.ShipType == ShipType.LPG);
                        if (size < lpg.First().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        if (size > lpg.Last().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                        var wiekszy = lpg.First(ship => ship.DWT > size);
                        var mniejszy = lpg.Last(ship => ship.DWT < size);


                        Utils.InterpolateDisplacement(size, wiekszy, mniejszy);
                        UpdateLabals();
                    }
                    else if (TypeOfShip.SelectedValue.ToString() == "Kontenerowiec")
                    {
                        var container = ships.FindAll(ship => ship.ShipType == ShipType.Container);
                        if (size < container.First().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        if (size > container.Last().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                        var wiekszy = container.First(ship => ship.DWT > size);
                        var mniejszy = container.Last(ship => ship.DWT < size);


                        Utils.InterpolateDisplacement(size, wiekszy, mniejszy);
                        UpdateLabals();
                    }
                    else if (TypeOfShip.SelectedValue.ToString() == "Statek Ro-Ro")
                    {
                        var roro = ships.FindAll(ship => ship.ShipType == ShipType.RoRo);
                        if (size < roro.First().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        if (size > roro.Last().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                        var wiekszy = roro.First(ship => ship.DWT > size);
                        var mniejszy = roro.Last(ship => ship.DWT < size);


                        Utils.InterpolateDisplacement(size, wiekszy, mniejszy);
                        UpdateLabals();
                    }
                    else if (TypeOfShip.SelectedValue.ToString() == "Prom")
                    {
                        var ferrie = ships.FindAll(ship => ship.ShipType == ShipType.Ferrie);
                        if (size < ferrie.First().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        if (size > ferrie.Last().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                        var wiekszy = ferrie.First(ship => ship.DWT > size);
                        var mniejszy = ferrie.Last(ship => ship.DWT < size);


                        Utils.InterpolateDisplacement(size, wiekszy, mniejszy);
                        UpdateLabals();
                    }
                    else if (TypeOfShip.SelectedValue.ToString() == "Statek pasażerski")
                    {
                        var passenger = ships.FindAll(ship => ship.ShipType == ShipType.Passenger);
                        if (size < passenger.First().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        if (size > passenger.Last().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                        var wiekszy = passenger.First(ship => ship.DWT > size);
                        var mniejszy = passenger.Last(ship => ship.DWT < size);


                        Utils.InterpolateDisplacement(size, wiekszy, mniejszy);
                        UpdateLabals();
                    }
                    else if (TypeOfShip.SelectedValue.ToString() == "Kabotażowiec")
                    {
                        var coaster = ships.FindAll(ship => ship.ShipType == ShipType.Coaster);
                        if (size < coaster.First().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        if (size > coaster.Last().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                        var wiekszy = coaster.First(ship => ship.DWT > size);
                        var mniejszy = coaster.Last(ship => ship.DWT < size);


                        Utils.InterpolateDisplacement(size, wiekszy, mniejszy);
                        UpdateLabals();
                    }
                    else if (TypeOfShip.SelectedValue.ToString() == "Statek rybacki")
                    {
                        var fisherman = ships.FindAll(ship => ship.ShipType == ShipType.Fisherman);
                        if (size < fisherman.First().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        if (size > fisherman.Last().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                        var wiekszy = fisherman.First(ship => ship.DWT > size);
                        var mniejszy = fisherman.Last(ship => ship.DWT < size);


                        Utils.InterpolateDisplacement(size, wiekszy, mniejszy);
                        UpdateLabals();
                    }
                    else if (TypeOfShip.SelectedValue.ToString() == "Masowiec")
                    {
                        var bulk = ships.FindAll(ship => ship.ShipType == ShipType.BulkCarrier);
                        if (size < bulk.First().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        if (size > bulk.Last().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                        var wiekszy = bulk.First(ship => ship.DWT > size);
                        var mniejszy = bulk.Last(ship => ship.DWT < size);


                        Utils.InterpolateDisplacement(size, wiekszy, mniejszy);
                        UpdateLabals();
                    }
                    else if (TypeOfShip.SelectedValue.ToString() == "Drobnicowiec")
                    {
                        var cargo = ships.FindAll(ship => ship.ShipType == ShipType.Cargo);
                        if (size < cargo.First().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        if (size > cargo.Last().DWT)
                        {
                            ShipLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                            return;
                        }
                        ShipLabel.BorderBrush = new SolidColorBrush(Colors.Green);


                        var wiekszy = cargo.First(ship => ship.DWT > size);
                        var mniejszy = cargo.Last(ship => ship.DWT < size);


                        Utils.InterpolateDisplacement(size, wiekszy, mniejszy);
                        UpdateLabals();
                    }
                }
            }
        }

        private void UpdateLabals()
        {
            DWTLabel.Content = ShipParameters.M.ToString();
            DLabel.Content = ShipParameters.DWT.ToString();
            LCLabel.Content = ShipParameters.Lcc.ToString();
            LPPLabel.Content = ShipParameters.Lpp.ToString();
            BCLabel.Content = ShipParameters.Bc.ToString();
            TCLabel.Content = ShipParameters.Tc.ToString();
            TCLabel.Content = ShipParameters.Tc.ToString();
            DELTALabel.Content = ShipParameters.Delta.ToString();

        }


        private void ShipLabel_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(ShipLabel.Text.IsNumeric())
                calculateShip();
        }
        private void RadioButtonShip1_Click(object sender, RoutedEventArgs e)
        {
            if (ShipLabel.Text.IsNumeric())
                calculateShip();
        }
        private void RadioButtonShip2_Click(object sender, RoutedEventArgs e)
        {
            if (ShipLabel.Text.IsNumeric())
                calculateShip();
        }
        private void TypeOfShip_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ShipLabel == null) return;
            if (ShipLabel.Text.IsNumeric())
                calculateShip();

            if (TypeOfShip.SelectedValue.ToString() == "Masowiec")
            {
                ShipPhoto.Source = new BitmapImage(new Uri(@"images\Bulk.jpg", UriKind.Relative));
            }
            if (TypeOfShip.SelectedValue.ToString() == "Drobnicowiec")
            {
                ShipPhoto.Source = new BitmapImage(new Uri(@"images\Cargo.jpg", UriKind.Relative));
            }
            if (TypeOfShip.SelectedValue.ToString() == "Zbiornikowiec")
            {
                ShipPhoto.Source = new BitmapImage(new Uri(@"images\Oil_Tanker.jpg", UriKind.Relative));
            }
            if (TypeOfShip.SelectedValue.ToString() == "Kontenerowiec")
            {
                ShipPhoto.Source = new BitmapImage(new Uri(@"images\Container.jpg", UriKind.Relative));
            }
            if (TypeOfShip.SelectedValue.ToString() == "Prom")
            {
                ShipPhoto.Source = new BitmapImage(new Uri(@"images\Ferrie.jpg", UriKind.Relative));
            }
            if (TypeOfShip.SelectedValue.ToString() == "Kabotażowiec")
            {
                ShipPhoto.Source = new BitmapImage(new Uri(@"images\Coaster.jpg", UriKind.Relative));
            }
            if (TypeOfShip.SelectedValue.ToString() == "Gazowiec LNG")
            {
                ShipPhoto.Source = new BitmapImage(new Uri(@"images\LNG_Tanker.jpg", UriKind.Relative));
            }
            if (TypeOfShip.SelectedValue.ToString() == "Gazowiec LPG")
            {
                ShipPhoto.Source = new BitmapImage(new Uri(@"images\LPG_Tanker.jpg", UriKind.Relative));
            }
            if (TypeOfShip.SelectedValue.ToString() == "Statek Ro-Ro")
            {
                ShipPhoto.Source = new BitmapImage(new Uri(@"images\RoRo.jpg", UriKind.Relative));
            }
            if (TypeOfShip.SelectedValue.ToString() == "Statek rybacki")
            {
                ShipPhoto.Source = new BitmapImage(new Uri(@"images\Fisherman.jpg", UriKind.Relative));
            }
            if (TypeOfShip.SelectedValue.ToString() == "Statek pasażerski")
            {
                ShipPhoto.Source = new BitmapImage(new Uri(@"images\Passenger.jpg", UriKind.Relative));
            }
        }
    }
}
