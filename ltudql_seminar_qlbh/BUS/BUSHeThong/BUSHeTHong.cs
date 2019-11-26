using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUSHeTHong
    {
        public DataTable getThongTin()
        {
            DALHeThong um = new DALHeThong();

            DataTable dt = um.getThongTin();


            return dt;
        }
        public DataTable getLinhVuc()
        {
            DALHeThong um = new DALHeThong();

            DataTable dt = um.getLinhVuc();


            return dt;
        }

        public void updateLinhVuc(DTOThongTin thongTin)
        {
            DALHeThong um = new DALHeThong();

            um.updateLinhVuc(thongTin);

        }

    }
}
