//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Music_Player
{
    using System;
    using System.Collections.Generic;
    
    public partial class KullaniciHareket
    {
        public decimal hareket_id { get; set; }
        public Nullable<decimal> kullanici_id { get; set; }
        public Nullable<System.DateTime> yaratılma_tarihi { get; set; }
        public string hareket_mesaj { get; set; }
    
        public virtual Kullanici Kullanici { get; set; }
    }
}