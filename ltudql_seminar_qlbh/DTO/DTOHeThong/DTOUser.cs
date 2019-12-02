using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOUser
    {
        public string userid { get; set; }

        public string username { get; set; }

        public string id { get; set; }
        public string userpassword { get; set; }
        public string userfullname { get; set; }
        public string roleid { get; set; }
        public string rolename { get; set; }
        public string roledes { get; set; }
        public bool isactive { get; set; }
    }
}
