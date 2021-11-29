using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Fashion.Entity
{
    public class ContactSystem
    {

        public int Contact_Id { set; get; }

        [DisplayName("Address")]
        public string Contact_Address { set; get; }

        [DisplayName("Phone")]
        public string Contact_Phone { set; get; }

        [DisplayName("Email")]
        public string Contact_Email { set; get; }

        [DisplayName("Website")]
        public string Contact_Website { set; get; }

        [DisplayName("Facebook")]
        public string Contact_Facebook { set; get; }

        [DisplayName("Twitter")]
        public string Contact_Twitter { set; get; }

        [DisplayName("Linkedin")]
        public string Contact_Linkedin { set; get; }

        [DisplayName("Instagram")]
        public string Contact_Instagram { set; get; }

        [DisplayName("Youtube")]
        public string Contact_Youtube { set; get; }

    }
}
