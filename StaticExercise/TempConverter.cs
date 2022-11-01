using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{

    // create a static class called TempConverter.The class should have at least 2 methods, one called
    // FahrenheitToCelsius that will require a double as a parameter and return a double, the other CelsiusToFahrenheit
    // which will also require a double as a parameter and return a double.

    // Fill out these methods and call them in your Program.cs file.Make sure they’re accurate! 
    public class TempConverter
    {
        public TempConverter()
        {

        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            var celcius = (fahrenheit - 32) / 1.8;

            return celcius;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {         
            var fahrenheit = (celsius * 1.8) + 32;

            return fahrenheit;
        }
    }
}
