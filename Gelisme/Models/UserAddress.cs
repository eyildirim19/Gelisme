using System;
using System.Collections.Generic;

namespace Gelisme.Models
{
    public partial class UserAddress
    {
        public int Id { get; set; }
        public string Baslik { get; set; } = null!;
        public string AcikAdres { get; set; } = null!;
        public string Il { get; set; } = null!;
        public string Ilce { get; set; } = null!;
        public int UserId { get; set; }
        public bool? Active { get; set; }
    }
}
