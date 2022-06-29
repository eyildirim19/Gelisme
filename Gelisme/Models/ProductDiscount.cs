using System;
using System.Collections.Generic;

namespace Gelisme.Models
{
    public partial class ProductDiscount
    {
        public int ProductId { get; set; }
        public decimal? Discount { get; set; }
    }
}
