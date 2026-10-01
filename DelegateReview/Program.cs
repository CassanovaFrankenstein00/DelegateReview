using System.Diagnostics;

namespace DelegateReview
{
    public delegate void Weather(string value1, int value2, float value3);
    class Doppler
    {
        public void WeatherReport(string string1, int number1, float number2, Weather myWeather)
        {
            myWeather(string1, number1, number2);
        }
        public void RainWeather(string input, int temp, float precipitation)
        {
            Console.WriteLine("Description: " + input);
            Console.WriteLine("Amount of Rainfall:" + precipitation);
            Console.WriteLine("Temperature in F: " + temp);
        }
        public void SnowWeather(string input, int temp, float precipitation)
        {
            Console.WriteLine("Description: " + input);
            Console.WriteLine("Amount of Rainfall:" + precipitation);
            Console.WriteLine("Temperature in F: " + temp);
        }
        public void SunWeather(string input, int temp, float precipitation)
        {
            Console.WriteLine("Description: " + input);
            Console.WriteLine("Amount of Rainfall:" + precipitation);
            Console.WriteLine("Temperature in F: " + temp);
        }
        public int menu()
        {
            Console.WriteLine("1.Record Weather\n2. Exit");
            string? input = Console.ReadLine();
            int choice;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 2)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 or 2.");
                input = Console.ReadLine();
            }
            return choice;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Doppler doppler = new Doppler();
            int selection = doppler.menu();
            while (selection != 2)
            {
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Which weather event would you like to record?(Rain/Snow/Sun)");
                        string? weatherEvent = ValidateInput(Console.ReadLine());
                        while (weatherEvent.Length == 0 || string.IsNullOrWhiteSpace(weatherEvent))
                        {
                            Console.WriteLine("Input cannot be empty. Please enter your routine.");
                            weatherEvent = Console.ReadLine();
                        }
                        if (weatherEvent.ToLower() == "rain")
                        {
                            Console.WriteLine("Describe the rain event?");
                            string? description = ValidateInput(Console.ReadLine());
                            while (description.Length == 0 || string.IsNullOrWhiteSpace(description))
                            {
                                Console.WriteLine("Input cannot be empty. Please enter your routine.");
                                description = Console.ReadLine();
                            }
                            Console.WriteLine("What is the temp of your rain event?");
                            string? temperatureInput = ValidateInput(Console.ReadLine());
                            int temperature;
                            while (!int.TryParse(temperatureInput, out temperature))
                            {
                                Console.WriteLine("Invalid input. Please enter a valid temperature.");
                                temperatureInput = Console.ReadLine();
                            }
                            Console.WriteLine("What is the precipitation of your rain event?(inches)");
                            string? precipitationInput = ValidateInput(Console.ReadLine());
                            float precipitation;
                            while (!float.TryParse(precipitationInput, out precipitation) || precipitation < 0)
                            {
                                Console.WriteLine("Invalid input. Please enter a valid precipitation value.");
                                precipitationInput = Console.ReadLine();
                            }
                            doppler.WeatherReport(description, temperature, precipitation, doppler.RainWeather);
                        }
                        else if (weatherEvent.ToLower() == "snow")
                        {
                            Console.WriteLine("Describe the snow event?");
                            string? description = ValidateInput(Console.ReadLine());
                            while (description.Length == 0 || string.IsNullOrWhiteSpace(description))
                            {
                                Console.WriteLine("Input cannot be empty. Please enter your routine.");
                                description = Console.ReadLine();
                            }
                            Console.WriteLine("What is the temp of your snow event?");
                            string? temperatureInput = ValidateInput(Console.ReadLine());
                            int temperature;
                            while (!int.TryParse(temperatureInput, out temperature))
                            {
                                Console.WriteLine("Invalid input. Please enter a valid temperature.");
                                temperatureInput = Console.ReadLine();
                            }
                            Console.WriteLine("What is the precipitation of your snow event?(inches)");
                            string? precipitationInput = ValidateInput(Console.ReadLine());
                            float precipitation;
                            while (!float.TryParse(precipitationInput, out precipitation) || precipitation < 0)
                            {
                                Console.WriteLine("Invalid input. Please enter a valid precipitation value.");
                                precipitationInput = Console.ReadLine();
                            }
                            doppler.WeatherReport(description, temperature, precipitation, doppler.SnowWeather);
                        }
                        else if (weatherEvent.ToLower() == "sun")
                        {
                            Console.WriteLine("Describe the sun event?");
                            string? description = ValidateInput(Console.ReadLine());
                            while (description.Length == 0 || string.IsNullOrWhiteSpace(description))
                            {
                                Console.WriteLine("Input cannot be empty. Please enter your routine.");
                                description = Console.ReadLine();
                            }
                            Console.WriteLine("What is the temp of your sun event?");
                            string? temperatureInput = ValidateInput(Console.ReadLine());
                            int temperature;
                            while (!int.TryParse(temperatureInput, out temperature))
                            {
                                Console.WriteLine("Invalid input. Please enter a valid temperature.");
                                temperatureInput = Console.ReadLine();
                            }
                            Console.WriteLine("What is the precipitation of your sun event?(inches)");
                            string? precipitationInput = ValidateInput(Console.ReadLine());
                            float precipitation;
                            while (!float.TryParse(precipitationInput, out precipitation) || precipitation < 0)
                            {
                                Console.WriteLine("Invalid input. Please enter a valid precipitation value.");
                                precipitationInput = Console.ReadLine();
                            }
                            doppler.WeatherReport(description, temperature, precipitation, doppler.SunWeather);
                        }
                        break;
                    case 2:

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;


                }
                selection = doppler.menu();
            }

        }
        static string ValidateInput(string input)
        {
            while (input.Length == 0 || string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input cannot be empty. Please enter your routine.");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
 