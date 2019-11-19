using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOUser
    {
        string userid;
        public string puserid
        {
            get
            {
                return userid;
            }
            set
            {
                userid = value;
            }
        }
        string username;
       public string pusername
        {
            get => username;
            set
            {
                username = value;
            }
        }
        string roleid;
        public string proleid
        {
            get => roleid;
            set
            {
                roleid = value;
            }
        }
        string rolename;
        public string prolename
        {
            get => rolename;
            set
            {
                rolename = value;
            }
        }
        string roledes;
        public string proledes
        {
            get => roledes;
            set
            {
                roledes = value;
            }
        }

    }
}
