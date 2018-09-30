using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace StandBand
{
    public class User
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }

    public class Event
    {
        public int ID { get; set; }
        public DateTime date_time_stamp { get; set; }
        public string band_name { get; set; }
        public string pub_location { get; set; }
        public int duration { get; set; }
    }

    public class SongList
    {
        public int ID { get; set; }
        public Array songs { get; set; }
    }

    public class Song
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string artist { get; set; }
        public string album { get; set; }
    }
}
