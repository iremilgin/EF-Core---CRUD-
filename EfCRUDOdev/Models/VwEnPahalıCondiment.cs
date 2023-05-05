using System;
using System.Collections.Generic;

namespace EfCRUDOdev.Models
{
    public partial class VwEnPahalıCondiment
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
