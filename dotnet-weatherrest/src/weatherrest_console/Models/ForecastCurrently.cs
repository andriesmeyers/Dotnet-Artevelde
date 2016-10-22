/*
nearestStormDistance: 90,
nearestStormBearing: 329
*/
using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class ForecastCurrently : Forecast
    {
        [DataMember(Name="nearestStormDistance")]
        public double NearestStormDistance { get; set; }
        [DataMember(Name="nearestStormBearing")]
        public double NearestStormBearing { get; set; }

        public ForecastCurrently() {
        }
    }
}
