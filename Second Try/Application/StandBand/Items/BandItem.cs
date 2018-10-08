using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace StandBand
{
	public class BandItem
	{
		string id;
		string name;
		List<int> songLists;

		[JsonProperty(PropertyName = "id")]
		public string Id
		{
			get { return id; }
			set { id = value;}
		}

		[JsonProperty(PropertyName = "name")]
		public string Name
		{
			get { return name; }
			set { name = value;}
		}

		[JsonProperty(PropertyName = "songLists")]
		public List<int> SongLists
		{
			get { return songLists; }
			set { songLists = value;}
		}

        [Version]
        public string Version { get; set; }
        public bool Done { get; internal set; }
    }
}

