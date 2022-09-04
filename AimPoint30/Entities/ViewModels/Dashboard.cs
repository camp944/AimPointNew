using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace AimPoint30.Entities.ViewModels
{
    public partial class DashboardViewModel
    {

        public SightDay1ViewModel Vday1 { get; set; }
        public SightDay7ViewModel Vday7 { get; set; }
        public SightMin6ViewModel Vmin6 { get; set; }
        public SightMin30ViewModel Vmin30 { get; set; }
        public SightHour3ViewModel Vhour3 { get; set; }
        public SightWeek4ViewModel Vweek4 { get; set; }

    }
}
