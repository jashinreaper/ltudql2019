using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUSLogin
    {
        static DALLogin dl = new DALLogin();
        public bool isCorrect(string username,string password)
        {
            if (dl.isExistUser(username,password))
            {
                return true;
            }
            else return false;
        }

        public string getRole(string username)
        {
            return dl.getRole(username);
        }
    }
}
