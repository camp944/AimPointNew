using System;
using System.Collections.Generic;

namespace AimPoint30.Entities.ViewModels
{
    public partial class SightHour3ViewModel
    {
        public int Id { get; set; }
        public string DateInit { get; set; } = null!;
        public decimal? PriceInit { get; set; }
        public decimal? PriceTarget { get; set; }
        public string? DateEnd { get; set; }
        public decimal? PriceEnd { get; set; }
    }
}
