using System;
using System.Collections.Generic;

namespace BMChallenge.Entities
{
    public class Weather
    {
        DateTime date { get; set; }
        DateTime date_br { get; set; }
        List<string> climate_temperature { get; set; }
    }
}
