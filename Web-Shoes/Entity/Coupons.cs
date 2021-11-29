using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Fashion.Entity
{
    public class Coupons
    {
        public string couponId { set; get; }

        [DisplayName("Coupon code")]
        public string couponCode { set; get; }

        [DisplayName("Price")]
        public int couponPrice { set; get; }

        [DisplayName("Amount")]
        public int couponAmount { set; get; }


    }
}
