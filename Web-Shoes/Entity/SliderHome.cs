using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Fashion.Entity
{
    public class SliderHome
    {
        public string SliderId { set; get; }

        [DisplayName("Name")]
        public string SliderName { set; get; }

        [DisplayName("Img 1")]
        public string SliderUrl1 { set; get; }

        [DisplayName("Img 2")]
        public string SliderUrl2 { set; get; }

        [DisplayName("Img 3")]
        public string SliderUrl3 { set; get; }

        [DisplayName("Img 4")]
        public string SliderUrl4 { set; get; }

        [DisplayName("Img 5")]
        public string SliderUrl5 { set; get; }

    }
}
