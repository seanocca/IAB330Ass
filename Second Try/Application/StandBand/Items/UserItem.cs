using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace StandBand.Items
{
    public class UserItem
    {
        string id;
        string username;
        string password;

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "username")]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        [JsonProperty(PropertyName = "password")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [Version]
        public string Version { get; set; }
    }
}
