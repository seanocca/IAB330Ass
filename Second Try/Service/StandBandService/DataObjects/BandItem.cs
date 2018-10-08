﻿using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StandBandService.DataObjects
{
    public class BandItem : EntityData
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public List<int> SongLists { get; set; }
    }
}