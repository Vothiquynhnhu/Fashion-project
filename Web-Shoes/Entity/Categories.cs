using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Fashion.Entity
{
    public class Categories
    {
        public int cg_Id { set; get; }

        [DisplayName("Name")]
        public string cg_Name { set; get; }

        [DisplayName("Type")]
        public string cg_Type { set; get; }

        [DisplayName("Sale")]
        public string cg_Sale { set; get; }
        public List<ProductsInCategories> ProductsInCategoriesC { get; set; }


    }
}
