using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUSDuLieu
    {
        public void backupDB(string path)
        {
            DALDuLieu um = new DALDuLieu();

           um.backupDB(path);

        }
    }
}
