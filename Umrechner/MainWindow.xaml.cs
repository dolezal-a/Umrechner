using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Umrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void CalculateDistance(object sender, KeyEventArgs e)
        {
            TextBox obj = sender as TextBox;
            decimal value = 0.0m;

            TxBlMessageBlock.Text = String.Empty;
            if (sender != TbMillimeter) TbMillimeter.Text = String.Empty;
            if (sender != TbCentimeter) TbCentimeter.Text = String.Empty;
            if (sender != TbMeter) TbMeter.Text = String.Empty;
            if (sender != TbKilometer) TbKilometer.Text = String.Empty;
            if (sender != TbInch) TbInch.Text = String.Empty;
            if (sender != TbFeet) TbFeet.Text = String.Empty;
            if (sender != TbYard) TbYard.Text = String.Empty;
            if (sender != TbMile) TbMile.Text = String.Empty;

            if(decimal.TryParse(obj.Text, out value))
            {
                if(sender == TbMillimeter)
                {
                    TbCentimeter.Text = Convert.Distance(value, Distance.Millimeter, Distance.Centimeter).ToString("F4");
                    TbMeter.Text = Convert.Distance(value, Distance.Millimeter, Distance.Meter).ToString("F4");
                    TbKilometer.Text = Convert.Distance(value, Distance.Millimeter, Distance.Kilometer).ToString("F4");
                    TbInch.Text = Convert.Distance(value, Distance.Millimeter, Distance.Inch).ToString("F4");
                    TbFeet.Text = Convert.Distance(value, Distance.Millimeter, Distance.Feet).ToString("F4");
                    TbYard.Text = Convert.Distance(value, Distance.Millimeter, Distance.Yard).ToString("F4");
                    TbMile.Text = Convert.Distance(value, Distance.Millimeter, Distance.Mile).ToString("F4");
                }
                if (sender == TbCentimeter)
                {
                    TbMillimeter.Text = Convert.Distance(value, Distance.Centimeter, Distance.Millimeter).ToString("F4");
                    TbMeter.Text = Convert.Distance(value, Distance.Centimeter, Distance.Meter).ToString("F4");
                    TbKilometer.Text = Convert.Distance(value, Distance.Centimeter, Distance.Kilometer).ToString("F4");
                    TbInch.Text = Convert.Distance(value, Distance.Centimeter, Distance.Inch).ToString("F4");
                    TbFeet.Text = Convert.Distance(value, Distance.Centimeter, Distance.Feet).ToString("F4");
                    TbYard.Text = Convert.Distance(value, Distance.Centimeter, Distance.Yard).ToString("F4");
                    TbMile.Text = Convert.Distance(value, Distance.Centimeter, Distance.Mile).ToString("F4");
                }
                if (sender == TbMeter)
                {
                    TbMillimeter.Text = Convert.Distance(value, Distance.Meter, Distance.Millimeter).ToString("F4");
                    TbCentimeter.Text = Convert.Distance(value, Distance.Meter, Distance.Centimeter).ToString("F4");
                    TbKilometer.Text = Convert.Distance(value, Distance.Meter, Distance.Kilometer).ToString("F4");
                    TbInch.Text = Convert.Distance(value, Distance.Meter, Distance.Inch).ToString("F4");
                    TbFeet.Text = Convert.Distance(value, Distance.Meter, Distance.Feet).ToString("F4");
                    TbYard.Text = Convert.Distance(value, Distance.Meter, Distance.Yard).ToString("F4");
                    TbMile.Text = Convert.Distance(value, Distance.Meter, Distance.Mile).ToString("F4");
                }
                if (sender == TbKilometer)
                {
                    TbMillimeter.Text = Convert.Distance(value, Distance.Kilometer, Distance.Millimeter).ToString("F4");
                    TbCentimeter.Text = Convert.Distance(value, Distance.Kilometer, Distance.Centimeter).ToString("F4");
                    TbMeter.Text = Convert.Distance(value, Distance.Kilometer, Distance.Meter).ToString("F4");
                    TbInch.Text = Convert.Distance(value, Distance.Kilometer, Distance.Inch).ToString("F4");
                    TbFeet.Text = Convert.Distance(value, Distance.Kilometer, Distance.Feet).ToString("F4");
                    TbYard.Text = Convert.Distance(value, Distance.Kilometer, Distance.Yard).ToString("F4");
                    TbMile.Text = Convert.Distance(value, Distance.Kilometer, Distance.Mile).ToString("F4");
                }
                if (sender == TbInch)
                {
                    TbMillimeter.Text = Convert.Distance(value, Distance.Inch, Distance.Millimeter).ToString("F4");
                    TbCentimeter.Text = Convert.Distance(value, Distance.Inch, Distance.Centimeter).ToString("F4");
                    TbMeter.Text = Convert.Distance(value, Distance.Inch, Distance.Meter).ToString("F4");
                    TbKilometer.Text = Convert.Distance(value, Distance.Inch, Distance.Kilometer).ToString("F4");
                    TbFeet.Text = Convert.Distance(value, Distance.Inch, Distance.Feet).ToString("F4");
                    TbYard.Text = Convert.Distance(value, Distance.Inch, Distance.Yard).ToString("F4");
                    TbMile.Text = Convert.Distance(value, Distance.Inch, Distance.Mile).ToString("F4");
                }
                if (sender == TbFeet)
                {
                    TbMillimeter.Text = Convert.Distance(value, Distance.Feet, Distance.Millimeter).ToString("F4");
                    TbCentimeter.Text = Convert.Distance(value, Distance.Feet, Distance.Centimeter).ToString("F4");
                    TbMeter.Text = Convert.Distance(value, Distance.Feet, Distance.Meter).ToString("F4");
                    TbKilometer.Text = Convert.Distance(value, Distance.Feet, Distance.Kilometer).ToString("F4");
                    TbInch.Text = Convert.Distance(value, Distance.Feet, Distance.Inch).ToString("F4");
                    TbYard.Text = Convert.Distance(value, Distance.Feet, Distance.Yard).ToString("F4");
                    TbMile.Text = Convert.Distance(value, Distance.Feet, Distance.Mile).ToString("F4");
                }
                if (sender == TbYard)
                {
                    TbMillimeter.Text = Convert.Distance(value, Distance.Yard, Distance.Millimeter).ToString("F4");
                    TbCentimeter.Text = Convert.Distance(value, Distance.Yard, Distance.Centimeter).ToString("F4");
                    TbMeter.Text = Convert.Distance(value, Distance.Yard, Distance.Meter).ToString("F4");
                    TbKilometer.Text = Convert.Distance(value, Distance.Yard, Distance.Kilometer).ToString("F4");
                    TbInch.Text = Convert.Distance(value, Distance.Yard, Distance.Inch).ToString("F4");
                    TbFeet.Text = Convert.Distance(value, Distance.Yard, Distance.Feet).ToString("F4");
                    TbMile.Text = Convert.Distance(value, Distance.Yard, Distance.Mile).ToString("F4");
                }
                if (sender == TbMile)
                {
                    TbMillimeter.Text = Convert.Distance(value, Distance.Mile, Distance.Millimeter).ToString("F4");
                    TbCentimeter.Text = Convert.Distance(value, Distance.Mile, Distance.Centimeter).ToString("F4");
                    TbMeter.Text = Convert.Distance(value, Distance.Mile, Distance.Meter).ToString("F4");
                    TbKilometer.Text = Convert.Distance(value, Distance.Mile, Distance.Kilometer).ToString("F4");
                    TbInch.Text = Convert.Distance(value, Distance.Mile, Distance.Inch).ToString("F4");
                    TbFeet.Text = Convert.Distance(value, Distance.Mile, Distance.Feet).ToString("F4");
                    TbYard.Text = Convert.Distance(value, Distance.Mile, Distance.Yard).ToString("F4");
                }
            }
            else
            {
                if (obj.Text == String.Empty)
                {
                    return;
                }

                TxBlMessageBlock.Text = "Geben Sie eine Zahl ein! Format: xx,xx";
            }
        }


        private void CalculateTemperature(object sender, KeyEventArgs e)
        {
            TextBox obj = sender as TextBox;
            decimal value = 0.0m;

            TxBlMessageBlock.Text = String.Empty;
            if (sender != TbKelvin) TbKelvin.Text = String.Empty;
            if (sender != TbCelsius) TbCelsius.Text = String.Empty;
            if (sender != TbFahrenheit) TbFahrenheit.Text = String.Empty;

            if (decimal.TryParse(obj.Text, out value))
            {
                if(sender == TbKelvin)
                {
                    TbCelsius.Text = Convert.Temperature(value, Temperature.Kelvin, Temperature.Celsius).ToString("F4");
                    TbFahrenheit.Text = Convert.Temperature(value, Temperature.Kelvin, Temperature.Fahrenheit).ToString("F4");
                }
                else if(sender == TbCelsius)
                {
                    TbKelvin.Text = Convert.Temperature(value, Temperature.Celsius, Temperature.Kelvin).ToString("F4");
                    TbFahrenheit.Text = Convert.Temperature(value, Temperature.Celsius, Temperature.Fahrenheit).ToString("F4");
                }
                else if(sender == TbFahrenheit)
                {
                    TbKelvin.Text = Convert.Temperature(value, Temperature.Fahrenheit, Temperature.Kelvin).ToString("F4");
                    TbCelsius.Text = Convert.Temperature(value, Temperature.Fahrenheit, Temperature.Celsius).ToString("F4");
                }
            }
            else
            {
                if (obj.Text == String.Empty)
                {
                    return;
                }

                TxBlMessageBlock.Text = "Geben Sie eine Zahl ein! Format: xx,xx";
            }
        }
    }
}
