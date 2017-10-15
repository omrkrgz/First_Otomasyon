using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Otomaston
{
    class AFaturaStok
    {
        public int Stok__id { get; set; }
        public string StokAdi_ { get; set; }
        public int Cari__id { get; set; }
        public string CariAdi_ { get; set; }
        public int Adet_ { get; set; }
        public decimal Fiyat_ { get; set; }
        public decimal Tutar_ { get; set; }
        public decimal iskonto { get; set; }

        //public override string ToString() => $"{StokAdi_} {CariAdi_} {Adet_}x{Fiyat_:c2}={Adet_ * Fiyat_:c2}";


    }
}
