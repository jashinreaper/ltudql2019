using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public static class DTOcurrentUser
    {
        public static string userid;
        public static string puserid
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
        public static string username;
        public static string pusername
        {
            get => username;
            set
            {
                username = value;
            }
        }
        public static string roleid;
        public static string proleid
        {
            get => roleid;
            set
            {
                roleid = value;
            }
        }
        public static string rolename;
        public static string prolename
        {
            get => rolename;
            set
            {
                rolename = value;
            }
        }
        public static string roledes;
        public static string proledes
        {
            get => roledes;
            set
            {
                roledes = value;
            }
        }
    }
}
