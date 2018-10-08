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
        List<SongItem> songList;

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
            get { return songList.ToString(); }
            set { songList.Add(song); }
        }

        [Version]
        public string Version { get; set; }
        public SongItem song { get; set; }
    }
}
