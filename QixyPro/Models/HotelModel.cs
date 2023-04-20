using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QixyPro.Models
{
    public class HotelModel
    {

        public int Sno { get; set; }
        public string Hotel { get; set; }
        public Nullable<System.DateTime> Arrival { get; set; }
        public Nullable<System.DateTime> Departure { get; set; }
        public string Types { get; set; }
        public Nullable<int> Guests { get; set; }
        public Nullable<int> price { get; set; }
    }
}