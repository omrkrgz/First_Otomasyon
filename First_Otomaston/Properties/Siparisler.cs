//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace First_Otomaston.Properties
{
    using System;
    using System.Collections.Generic;
    
    public partial class Siparisler
    {
        public int SiparisId { get; set; }
        public Nullable<int> Cari_id { get; set; }
        public Nullable<int> Personel_id { get; set; }
        public Nullable<System.DateTime> SiparisTarihi { get; set; }
        public Nullable<decimal> SiparisFiyat { get; set; }
        public Nullable<decimal> SiparisTutar { get; set; }
        public Nullable<int> Stok_id { get; set; }
        public Nullable<System.DateTime> TeslimTarihi { get; set; }
        public Nullable<decimal> indirim { get; set; }
        public Nullable<int> SiparisAdet { get; set; }
    
        public virtual Cariler Cariler { get; set; }
        public virtual Personel Personel { get; set; }
        public virtual Stoklar Stoklar { get; set; }
    }
}
