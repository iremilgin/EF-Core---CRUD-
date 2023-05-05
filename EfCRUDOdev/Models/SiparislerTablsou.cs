using System;
using System.Collections.Generic;

namespace EfCRUDOdev.Models
{
    public partial class SiparislerTablsou
    {
        public int? SiparisId { get; set; }
        public int? MusteriId { get; set; }
        public string? YemekSirketi { get; set; }
        public string? Urun { get; set; }
        public int? Adet { get; set; }
        public decimal? BirimFİyati { get; set; }
        public decimal? ToplamFiyati { get; set; }

        public virtual Musteriler? Musteri { get; set; }
    }
}
