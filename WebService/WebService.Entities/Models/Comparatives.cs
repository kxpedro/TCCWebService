using System;
using System.Collections.Generic;
using System.Text;
using WebService.Entities.Enum;

namespace WebService.Entities.Models
{
    public class Comparatives
    {   
        public string TransporteType { get; set; }
        public string Preference { get; set; }
        public int Distance { get; set; }
        public int Duration { get; set; }
        public double Cost { get; set; }
        public Address AddressOrigin { get; set; }
        public Address AddressDestine { get; set; }

        //public List<ComparativeOptions> ComparativeOptions { get; set; }

        //public OptionValue BestOptionValue { get; set; }
        //public OptionDuration BestOptionDuration { get; set; }
        //public OptionDistance BestOptionDistance { get; set; }

        //public ePreferences Preferences { get; set; }
    }

    public class ComparativeOptions
    {
        public int OptionDistance { get; set; }
        public int OptionDuration { get; set; }
        public double OptionValue { get; set; }

        public ePreferences Preferences { get; set; }
        public eTransportOptions TransportOptions { get; set; }
    }

    //public class OptionDistance
    //{
    //    public eTransportOptions TransportOptions { get; set; }
    //    public double Value { get; set; }
    //}

    //public class OptionDuration
    //{
    //    public eTransportOptions TransportOptions { get; set; }
    //    public int Value { get; set; }
    //}

    //public class OptionValue
    //{
    //    public eTransportOptions TransportOptions { get; set; }
    //    public double Value { get; set; }
    //}
}
