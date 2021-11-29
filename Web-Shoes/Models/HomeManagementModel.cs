using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Fashion.Entity;

namespace Web_Fashion.Models
{
    public class HomeManagementModel
    {
        public SliderHome SliderHome { set; get; }
        public CategoriesHome CategoriesHome { set; get; }
        public CustomerHome customerHome { set; get; }

    }
}
