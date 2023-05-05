using System;
using System.Collections.Generic;

namespace EfCRUDOdev.Models
{
    public partial class VwMusteriAlısveri
    {
        public string CompanyName { get; set; } = null!;
        public int OrderId { get; set; }
        public double? SiparişTutarı { get; set; }
    }
}
