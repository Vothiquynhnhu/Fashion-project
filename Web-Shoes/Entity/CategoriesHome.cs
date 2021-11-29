using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Entity
{
    public class CategoriesHome
    {
        public string CategoriesHomeId { set; get; }

        [DisplayName("Name")]
        public string CategoriesHomeName { set; get; }

        [DisplayName("Img 1")]
        public string CategoriesHomeUrl1 { set; get; }

        [DisplayName("Img 2")]
        public string CategoriesHomeUrl2 { set; get; }

        [DisplayName("Img 3")]
        public string CategoriesHomeUrl3 { set; get; }

        [DisplayName("Img 4")]
        public string CategoriesHomeUrl4 { set; get; }

        [DisplayName("Img 5")]
        public string CategoriesHomeUrl5 { set; get; }

        [DisplayName("Img 6")]
        public string CategoriesHomeUrl6 { set; get; }

        [DisplayName("Img 7")]
        public string CategoriesHomeUrl7 { set; get; }

        [DisplayName("Img 8")]
        public string CategoriesHomeUrl8 { set; get; }
    }
}
