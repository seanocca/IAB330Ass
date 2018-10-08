using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace StandBand.Items
{
    public class EventItem
    {
        string id;
        string name;
        string location;
        double longitude;
        double latitude;

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [JsonProperty(PropertyName = "location")]
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        [JsonProperty(PropertyName = "longitude")]
        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        [JsonProperty(PropertyName = "latitude")]
        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        [Version]
        public string Version { get; set; }
    }
}
