using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Models
{
    public class UserListModel
    {
        
        public string User_Id { get; set; }

        [DisplayName("UserName")]
        public string User_UserName { get; set; }

        [DisplayName("FirstName")]
        public string User_FirstName { get; set; }

        [DisplayName("LastName")]
        public string User_LastName { get; set; }

        [DisplayName("Email")]
        public string User_Email { get; set; }

        [DisplayName("Role")]
        public string User_Role { get; set; }

    }
}
