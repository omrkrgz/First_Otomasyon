//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace First_Otomaston
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stoklar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stoklar()
        {
            this.Siparislers = new HashSet<Siparisler>();
            this.AlisFaturalaris = new HashSet<AlisFaturalari>();
        }
    
        public int Stokid { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string StokBarkod { get; set; }
        public Nullable<int> Kategori_id { get; set; }
        public string StokResmiYolu { get; set; }
        public Nullable<int> StokAdet { get; set; }
        public Nullable<int> Durum_id { get; set; }
    
        public virtual StokKategori StokKategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparisler> Siparislers { get; set; }
        public virtual AktifPasifDurum AktifPasifDurum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlisFaturalari> AlisFaturalaris { get; set; }
    }
}
