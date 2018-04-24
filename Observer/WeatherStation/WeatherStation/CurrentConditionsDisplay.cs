using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void Display()
        {
            Console.WriteLine("Current Conditions");
            Console.WriteLine($"Temp: {_temperature.ToString("N2")}");
            Console.WriteLine($"Humidity: {_humidity.ToString("N2")}");
            Console.WriteLine($"Pressure: {_pressure.ToString("N2")}");
            Console.WriteLine();
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
        }
    }
}
