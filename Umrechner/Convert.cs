namespace Umrechner
{
    public static class Convert
    {
        public static decimal Temperature(decimal value, Temperature from, Temperature to)
        {
            decimal isoValue = 0.0m;
            decimal result = 0.0m;

            if (from == to) return value;
            if (from == Umrechner.Temperature.Kelvin) isoValue = value;
            if (from == Umrechner.Temperature.Celsius) isoValue = value + 273.15m;
            if (from == Umrechner.Temperature.Fahrenheit) isoValue = (value - 32) * 5 / 9 + 273.15m;

            if (to == Umrechner.Temperature.Kelvin) result = isoValue;
            if (to == Umrechner.Temperature.Celsius) result = isoValue - 273.15m;
            if (to == Umrechner.Temperature.Fahrenheit) result = (isoValue - 273.15m) * 9 / 5 + 32;

            return result;
        }


        public static decimal Distance(decimal value, Distance from, Distance to)
        {
            decimal isoValue = 0.0m;
            decimal impValue = 0.0m;
            decimal result = 0.0m;
            bool impToIso = false;

            if (from == to) return value;
            if (from == Umrechner.Distance.Meter)
            {
                isoValue = value;
            }
            if (from == Umrechner.Distance.Centimeter)
            {
                isoValue = value / 100;
            }
            if (from == Umrechner.Distance.Millimeter)
            {
                isoValue = value / 1000;
            }
            if (from == Umrechner.Distance.Kilometer)
            {
                isoValue = value * 1000;
            }
            if( from == Umrechner.Distance.Inch)
            {
                impToIso = true;
                impValue = value;
            }
            if (from == Umrechner.Distance.Feet)
            {
                impToIso = true;
                impValue = value * 12;
            }
            if( from == Umrechner.Distance.Yard)
            {
                impToIso = true;
                impValue = value * 36;
            }
            if( from == Umrechner.Distance.Mile)
            {
                impToIso = true;
                impValue = value * 63360;
            }


            if (impToIso)
            {
                isoValue = impValue / 39.3701m;
            }
            else
            {
                impValue = isoValue * 39.3701m;
            }


            if (to == Umrechner.Distance.Meter) result = isoValue;
            if (to == Umrechner.Distance.Centimeter) result = isoValue * 100;
            if (to == Umrechner.Distance.Millimeter) result = isoValue * 1000;
            if (to == Umrechner.Distance.Kilometer) result = isoValue / 1000;
            if (to == Umrechner.Distance.Inch) result = impValue;
            if (to == Umrechner.Distance.Feet) result = impValue / 12;
            if (to == Umrechner.Distance.Yard) result = impValue / 36;
            if (to == Umrechner.Distance.Mile) result = impValue / 63360;

            return result;
        }
    }


    public enum Temperature
    {
        Kelvin,
        Celsius,
        Fahrenheit
    }


    public enum Distance
    {
        Millimeter,
        Centimeter,
        Meter,
        Kilometer,
        Inch,
        Feet,
        Yard,
        Mile
    }
}
