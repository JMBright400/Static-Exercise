namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = -40.0;
            double celsius = TempConverter.FahrenheitToCelcius(fahrenheit);
            Console.WriteLine($"{fahrenheit} F is equal to {celsius} C");

            celsius = -40.0;
            fahrenheit = TempConverter.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius} C is equal to {fahrenheit} F");

            //-40 Celsius and -40 Fahrenheit are equal.
        }
    }
}
