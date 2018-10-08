using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StandBandService.DataObjects
{
    public class SongListItem : EntityData
    {
        public int ID { get; set; }

        public int BandID { get; set; }

        public List<SongItem> SongList { get; set; }
    }
}