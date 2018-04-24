using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class WeatherData : ISubject
    {
        private Random _random;
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private List<IObserver> _observers;

        public WeatherData() => _random = new Random();

        public void NotifyObservers()
        {
            foreach(IObserver observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }
        
        public void RegisterObserver(IObserver observer)
        {
            if (_observers == null) _observers = new List<IObserver>();

            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (_observers == null) _observers = new List<IObserver>();

            _observers.Remove(observer);
        }

        public float GetTemperature() { return (float)(_random.NextDouble()); }

        public float GetHumidity() { return (float)(_random.NextDouble()); }

        public float GetPressure() { return (float)(_random.NextDouble()); }

        public void MeasurementsChanged()
        {
            _temperature = GetTemperature();
            _humidity = GetHumidity();
            _pressure = GetPressure();

            NotifyObservers();
        }
    }
}
