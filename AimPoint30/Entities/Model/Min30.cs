using System;
using System.Collections.Generic;

namespace AimPoint30.Entities.Model
{
    public partial class Min30
    {
        public int Id { get; set; }
        public string DateRequest { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
