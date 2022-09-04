using System;
using System.Collections.Generic;

namespace AimPoint30.Entities.ViewModels
{
    public partial class Min30ViewModel
    {
        public int Id { get; set; }
        public string DateRequest { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
