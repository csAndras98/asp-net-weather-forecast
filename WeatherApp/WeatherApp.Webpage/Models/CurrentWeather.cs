﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Webpage.Models
{
    public class CurrentWeather
    {
        public long ID { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public double Temp { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public double Wind { get; set; }
    }
}