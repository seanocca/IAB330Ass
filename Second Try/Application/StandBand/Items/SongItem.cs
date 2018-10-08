using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace StandBand.Items
{
    public class SongItem
    {
        string id;
        string name;
        string artist;

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

        [JsonProperty(PropertyName = "artist")]
        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        [Version]
        public string Version { get; set; }
    }
}
