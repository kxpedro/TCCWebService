using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
