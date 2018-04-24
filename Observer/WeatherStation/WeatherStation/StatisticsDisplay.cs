using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class StatisticsDisplay : IDisplayElement, IObserver
    {
        float _minTemp = 1.0f;
        float _maxTemp = 0.0f;
        List<float> _temperatures;

        public void Display()
        {
            Console.WriteLine("Weather Stats");
            Console.WriteLine($"Avg. temp: {_temperatures.Average().ToString("N2")}");
            Console.WriteLine($"Min. temp: {_minTemp.ToString("N2")}");
            Console.WriteLine($"Max. temp: {_maxTemp.ToString("N2")}");
            Console.WriteLine();
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            if (temperature < _minTemp) _minTemp = temperature;
            if (temperature > _maxTemp) _maxTemp = temperature;

            if (_temperatures == null) _temperatures = new List<float>();

            _temperatures.Add(temperature);
        }
    }
}
