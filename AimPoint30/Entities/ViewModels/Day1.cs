using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace AimPoint30.Entities.ViewModels
{
    public partial class Day1ViewModel
    {

        public int Id { get; set; }
        public string DateRequest { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
