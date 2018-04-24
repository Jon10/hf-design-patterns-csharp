using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay();
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();

            weatherData.RegisterObserver(currentConditionsDisplay);
            weatherData.RegisterObserver(statisticsDisplay);

            weatherData.MeasurementsChanged();

            currentConditionsDisplay.Display();
            statisticsDisplay.Display();

            weatherData.MeasurementsChanged();

            currentConditionsDisplay.Display();
            statisticsDisplay.Display();

            Console.ReadKey();
        }
    }
}
