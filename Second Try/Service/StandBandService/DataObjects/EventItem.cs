using Microsoft.Azure.Mobile.Server;
using System.Collections.Generic;

namespace StandBandService.DataObjects
{
    public class EventItem : EntityData
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }
    }   
}