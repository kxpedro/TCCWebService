using System;
using System.Collections.Generic;
using System.Text;
using WebService.Entities.Enum;

namespace WebService.Entities.Consumer
{
    public class Options
    {
        /// <summary>
        /// Value in Meters
        /// </summary>
        public int DistanceValue { get; set; }

        /// <summary>
        /// Value in Seconds
        /// </summary>
        public int DurationValue { get; set; }

        /// <summary>
        /// Value in Seconds
        /// </summary>
        public int TrafficDurationValue { get; set; }

        public string Description { get; set; }
        public double CostValue { get; set; }
    }

    public class OptionDistance
    {
        public eTransportOptions TransportOptions { get; set; }
        public double Value { get; set; }
    }

    public class OptionDuration
    {
        public eTransportOptions TransportOptions { get; set; }
        public int Value { get; set; }
    }

    public class OptionValue
    {
        public eTransportOptions TransportOptions { get; set; }
        public double Value { get; set; }
    }

}
