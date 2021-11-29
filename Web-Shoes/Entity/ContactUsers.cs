using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Entity
{
    public class ContactUsers
    {

        public int cu_Id { set; get; }

        [DisplayName("FirstName")]
        public string cu_FirstName { set; get; }

        [DisplayName("LastName")]
        public string cu_LastName { set; get; }

        [DisplayName("Email")]
        public string cu_Email { set; get; }

        [DisplayName("Subject")]
        public string cu_Subject { set; get; }

        [DisplayName("Description")]
        public string cu_Description { set; get; }

    }
}
