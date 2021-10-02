using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Entity
{
    public class UserInDevice
    {
        public AppUser AppUser { set; get; }
        public string UiD_UserId { set; get; }


        public Device Device { set; get; }
        public string UiD_DeviceId { set; get; }
        
    }
}
