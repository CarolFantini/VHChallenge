using System;
using System.Collections.Generic;

namespace BMChallenge.Entities
{
    public class Forecast
    {
        public int id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string meteogram { get; set; }
        public List<Weather> data { get; set; }
        public Forecast()
        {
            data = new List<Weather>();
        }
    }
}
