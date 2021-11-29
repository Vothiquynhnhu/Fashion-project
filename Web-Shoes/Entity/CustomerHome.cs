using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Entity
{
    public class CustomerHome
    {
        public string CustomerHomeId { set; get; }

        [DisplayName("Name")]
        public string CustomerHomeName { set; get; }

        [DisplayName("Img")]
        public string CustomerHome_CImg { set; get; }

        [DisplayName("Name")]
        public string CustomerHome_CName { set; get; }

        [DisplayName("Work")]
        public string CustomerHome_CWork { set; get; }

        [DisplayName("Star")]
        public int CustomerHome_CStar { set; get; }

        [DisplayName("Description")]
        public string CustomerHome_CDesription { set; get; }

    }
}
