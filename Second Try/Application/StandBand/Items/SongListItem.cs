using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace StandBand.Items
{
    public class SongListItem
    {
        string id;
        string name;

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

        [JsonProperty(PropertyName = "songList")]
        public string SongList
        {
            get; set;
        }

        [Version]
        public string Version { get; set; }
        public SongItem Song { get; set; }
    }
}
