using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StandBandService.DataObjects
{
    public class UserItem : EntityData
    {
        public int ID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}