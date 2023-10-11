using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelcius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }

        public static double CelsiusToFahrenheit(double celsius) 
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
    }

}
