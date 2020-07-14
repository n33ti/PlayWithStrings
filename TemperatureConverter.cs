using System;
using System.Collections.Generic;
using System.Text;

namespace PlayWithStrings
{
   static class TemperatureConverter
    {
       public static double ToFahrenheit(double celcius)
        {
      
            return 32.00 + (9.00 / 5.00 * celcius);
        }

        public static double ToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32.00) * 5.00 / 9.00;
        }

    }
}
