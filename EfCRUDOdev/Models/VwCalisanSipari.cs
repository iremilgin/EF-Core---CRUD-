using System;
using System.Collections.Generic;

namespace EfCRUDOdev.Models
{
    public partial class VwCalisanSipari
    {
        public string AdSoyad { get; set; } = null!;
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
