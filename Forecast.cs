using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Forecast
    {
        public int temperature;
        public string status;
        public int forecastTemperature;
        public string forecastStatus;
        //creating dailyforecast for game
        public String[] StatusOfForecast = new string[] { "cloudy", "Rainy", "Sunny", "Furries", "Foggy", };
        public int[] TemperatureOfForecast = new int[] { 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };

        public Forecast()
        {
            this.random = Random;
        }

        public void StatusOfDay()
        {
            int WeatherStatus = random.Next(0, StatusOfForecast.Length);
            status = (StatusOfForecast[StatusOfDay]);
        }
        public void TemperatureStatus()
        {
            int TemperatureStatus = random.Next(0, TemperatureOfForecast.Length);
            temperature = (TemperatureOfForecast[WeatherStatus]);
        }

        public void MakeDailyForecast()
        {
            List<string> forecastForDay = new List<string> { "Today" };
            foreach (string day in forecastForDay)
            {
                StatusOfDay();
                TemperatureStatus();
            }
        }

        public void ForecastStatus()
        {
            int WeatherStatus = random.Next(0, StatusOfForecast.Length);
            forecastStatus = (StatusOfForecast[WeatherStatus]);
        }

        public void ForecastTemperature()
        {
            int TemperatureStatus = random.Next(0, TemperatureOfForecast.Length);
            forecastTemperature = (StatusOFForecast[TemperatureStatus]);
        }

        public void ShowDaysForecast()
        {
            Console.WriteLine("Today's forecast is : {0} {1}\n\n", temperature, status);
        }
        public void MakeTomorrowsForecast()
        {
            List<string> forecastForDay = new List<string> {"Tomorrow's }
                foreach (string day in forecastForDay)
            {
                forecastStatus();
                forecastTemperature();
                Console.WriteLine(day + "forecast is : {0} {1} \n\n", forecastStatus, forecastTemperature);
            }
        }
    }
}
