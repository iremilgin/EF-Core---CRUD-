using System;
using System.Collections.Generic;

namespace EfCRUDOdev.Models
{
    public partial class VCondimentsTop5
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
    }
}
