//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QixyPro
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
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
