using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Entity
{
    public class Subscribers
    {
        public string Subs_Id { set; get; }

        [DisplayName("Email")]
        public string Subs_Mail { set; get; }

        [DisplayName("Time Upload")]
        public DateTime Subs_TimeUpdate { set; get; }

    }
}
